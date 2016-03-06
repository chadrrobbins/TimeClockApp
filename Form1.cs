using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeClockApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DateTime payStart;
        DateTime payEnd;
        static string[] Scopes = { CalendarService.Scope.CalendarReadonly };
        static string ApplicationName = "Google Calendar API .NET Quickstart";

        private void dtpPayStart_ValueChanged(object sender, EventArgs e)
        {
            payStart = dtpPayStart.Value;
        }

        private void dtpPayEnd_ValueChanged(object sender, EventArgs e)
        {
            payEnd = dtpPayEnd.Value;
        }

        private void btnCalcEmpHours_Click(object sender, EventArgs e)
        {
            UserCredential credential;
            var Functions = new GoogleTimeClock.Functions();
            
            //Open file IO stream.
            Functions.OpenFileStream(out credential, Scopes);


            // Create Google Calendar API service.            
            var service = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Define parameters of request.            
            EventsResource.ListRequest request = service.Events.List("mba2940@gmail.com");
            request.TimeMin = payStart;
            request.TimeMax = payEnd;
            request.ShowDeleted = false;
            request.SingleEvents = true;
            request.MaxResults = 40;
            request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

            // List events.
            Events events = request.Execute();            
            if (events.Items != null && events.Items.Count > 0)
            {
                lbEmpHours.Items.Clear();
                dgvEmpHours.Rows.Clear();

                foreach (var eventItem in events.Items)
                {
                    // 1/15/2016 7:30:00 AM                                        
                    string email = eventItem.Creator.Email.ToString();
                    string start = eventItem.Start.DateTime.ToString();
                    string end = eventItem.End.DateTime.ToString();
                    string summary = eventItem.Summary.ToString();
                    string location = null;

                    if (eventItem.Location == null)
                    {
                        location = "No location selected.";
                    }
                    else
                    {
                        location = eventItem.Location.ToString();
                    }
                    
                    
                    DateTime start_date = Functions.CreateDateTime(start);
                    DateTime end_date = Functions.CreateDateTime(end);

                    string startDateString = start_date.ToShortDateString();
                    string startTimeString = start_date.ToShortTimeString();
                    string endTimeString = end_date.ToShortTimeString();

                    lbEmpHours.Items.Add(summary);
                    lbEmpHours.Items.Add("\r\nDate: " + startDateString);
                    lbEmpHours.Items.Add("\r\nStart time: " + startTimeString);
                    lbEmpHours.Items.Add("\r\nEnd time: " + endTimeString);
                    lbEmpHours.Items.Add("\r\nEmail: " + email);
                    lbEmpHours.Items.Add("Total: " + (eventItem.End.DateTime - eventItem.Start.DateTime) + "\r\n");
                    lbEmpHours.Items.Add("\r");

                    dgvEmpHours.Rows[0].Cells[0].Value = email;
                    dgvEmpHours.Rows[0].Cells[1].Value = startDateString;
                    dgvEmpHours.Rows[0].Cells[2].Value = summary;
                    dgvEmpHours.Rows[0].Cells[3].Value = location;
                    dgvEmpHours.Rows[0].Cells[4].Value = startTimeString;
                    dgvEmpHours.Rows[0].Cells[5].Value = endTimeString;
                    dgvEmpHours.Rows[0].Cells[6].Value = eventItem.End.DateTime - eventItem.Start.DateTime;
                    dgvEmpHours.Rows.Insert(0, 1);
                }
                dgvEmpHours.Rows.RemoveAt(0);
            }
            else
            {
                lbEmpHours.Items.Add("No jobs found.");
            }

            
        }
    }
}
