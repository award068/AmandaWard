using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace OhioHealth
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            DateTime t1 = new DateTime(dtStart.Value.Year, dtStart.Value.Month, dtStart.Value.Day, 17, 0, 0);
            DateTime t2 = new DateTime(dtEnd.Value.Year, dtEnd.Value.Month, (dtStart.Value.Day + 1), 4, 0, 0);
            DateTime tMidnight = new DateTime(dtEnd.Value.Year, dtEnd.Value.Month, (dtStart.Value.Day + 1), 0, 0, 0);
            DateTime startTimeTrue = new DateTime(dtStart.Value.Year, dtStart.Value.Month, dtStart.Value.Day, startTime.Value.Hour, startTime.Value.Minute, 0);
            DateTime bedTimeTrue = new DateTime(dtStart.Value.Year, dtStart.Value.Month, dtStart.Value.Day, bedTime.Value.Hour, bedTime.Value.Minute, 0);
            DateTime bedTimeNext = new DateTime(dtStart.Value.Year, dtStart.Value.Month, (dtStart.Value.Day + 1), bedTime.Value.Hour, bedTime.Value.Minute, 0);
            DateTime endTimeTrue = new DateTime(dtEnd.Value.Year, dtEnd.Value.Month, dtEnd.Value.Day, endTime.Value.Hour, endTime.Value.Minute, 0);

            if (endTimeTrue >= startTimeTrue)//confirm date End is after date start
            {
                if (startTimeTrue >= t1)//confirm start time is no earlier than 5pm
                {
                    DateTime bed;
                    if (bedTime.Value >= startTime.Value)
                    {
                        bed = bedTimeTrue;
                    }
                    else
                    {
                        bed = bedTimeNext;
                    }


                    if (endTimeTrue <= t2)//confirm end time is no later than 4am
                    {
                        //ALL DATA HERE
                        //CalculateData();//method for calculating $$$

                        int startCur;
                        int bedCur;
                        int endCur;
                        int finalCur;                                              

                        if (bed < tMidnight && endTimeTrue >= tMidnight) //---check to see if bedtime is before midnight
                                                       //---if bedtime is earlier than midnight calculate time from bedtime to midnight   
                        {
                            //$12/hr start time to bed time
                            //Bedtime - startTime = #hours * 12  
                            var startHrs = (int)Math.Ceiling((bed - startTimeTrue).TotalHours);
                            startCur = (startHrs * 12);

                            //$8/hr bed time to midnight
                            //midnightTime - Bedtime = #hours * $8
                            var bedHrs = (int)Math.Ceiling((tMidnight - bed).TotalHours);
                            bedCur = ((Math.Max(0,bedHrs)) * 8);

                            //$16/hr midnight to endtime
                            //endTime - midnightTime = #hours * 16
                            var endHrs = (int)Math.Ceiling((endTimeTrue - tMidnight).TotalHours);
                            endCur = ((Math.Max(0,endHrs)) * 16);
                                                       
                            finalCur = startCur + bedCur + endCur;

                            MessageBox.Show("$" + finalCur.ToString());
                        }//closing (bed < tMidnight)                    

                        else if (bed < tMidnight && endTimeTrue < tMidnight) //if bed time is less than midnight and end time is less than midnight
                        {
                            //$12/hr start time to bed time
                            //Bedtime - startTime = #hours * 12  
                            var startHrs = (int)Math.Ceiling((bed - startTimeTrue).TotalHours);
                            startCur = (startHrs * 12);

                            //$8/hr bed time to midnight
                            //midnightTime - Bedtime = #hours * $8
                            var bedHrs = (int)Math.Ceiling((endTimeTrue - bed).TotalHours);
                            bedCur = ((Math.Max(0, bedHrs)) * 8);

                            finalCur = startCur + bedCur;
                            MessageBox.Show("$" + finalCur.ToString());
                        }
                        else if (bed >= tMidnight) //---check to see if bedtime is midnight or later 
                                                             //---if bedtime is later than midnight
                        {
                            //$12/hr start time to midnight
                            //midnightTime - startTime = #hours * 12
                            var startHrs = (int)Math.Ceiling((tMidnight - startTimeTrue).TotalHours);
                            startCur = (startHrs * 12);

                            //$16/hr midnight to endtime
                            //endTime - midnightTime = #hours * 16
                            var hrs3 = (int)Math.Ceiling((endTimeTrue - bed).TotalHours);
                            endCur = ((Math.Max(0,hrs3)) * 16);

                            finalCur = startCur + endCur;
                            MessageBox.Show("$"+finalCur.ToString());
                        }//closing (bed >= tMidnight)

                        //*****no fractions

                        //but there's a possibility they babysit and don't put the baby to bed -- end babysitting before bed time
                        //maybe create a checkbox if didn't put the baby to bed

                        this.Hide();
                        //MessageBox.Show(finalCur.ToString());
                        Application.Exit();
                    }//if (endTime <= t2) closing

                    else if (endTimeTrue > t2)//end time is later than 4am
                    {
                        MessageBox.Show("Change End Time to 4am or earlier.");
                    }//else if (endTime > t2) closing
                }// if (startTime.Value >= t1) closing

                else if (dtStart.Value > t1)//start time is earlier than 5pm
                {
                    MessageBox.Show("Change Start Time to 5pm or later.");
                }//else if (startTime.Value > t1) closing

                else
                {
                    MessageBox.Show("ERROR!");
                    this.Hide();
                    Application.Exit();
                }//else closing
            }//if (dateEnd.Value >= dateStart.Value) closing

            else
            {
                MessageBox.Show("End Date is before Start Date.");
            }//else closing




        }//OKBtn_Click closing




        //method for calculating $$$
        private void CalculateData()
        {
            





        }//CalculateData closing
    }//Form 1 closing
}//OhioHealth Namespace closing
