﻿using Municipality_Services_PROG7321_POE.Classes;
using Municipality_Services_PROG7321_POE.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Mayra Selemane
//ST10036905
//PROG7321 POE PART 1
//Class used to manipulate the main form

namespace Municipality_Services_PROG7321_POE
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// declaring an object to represent report form.
        /// </summary>
        Reporting reportForm;

        /// <summary>
        /// declaring an object from issues form.
        /// </summary>
        Issues issuesForm;

        /// <summary>
        /// default constructor.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            InitializeWelcomeUI();
        }

        /// <summary>
        /// method to initialize the welcoming User Interface.
        /// </summary>
        private void InitializeWelcomeUI()
        {

            // Adding a header panel to the main page
            Panel headerPanel = new Panel
            {
                Size = new Size(this.Width, 80),
                BackColor = Color.SlateGray,
                Dock = DockStyle.Top
            };
            this.Controls.Add(headerPanel);

            // Adding a label text to the main page
            Label titleLabel = new Label
            {
                Text = "Welcome to Municipal Services",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                AutoSize = true,
                ForeColor = Color.White,
                Location = new Point(20, 25)
            };
            headerPanel.Controls.Add(titleLabel);
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// method that allows user to apply for a report issue with menu strip visible.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void applyNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (reportForm == null)
            {
                //initializing report object
                reportForm = new Reporting();
                //making the object an MDI parent
                reportForm.MdiParent = this;
                //filling the form and showing
                reportForm.Dock = DockStyle.Fill;
                reportForm.Show();
            }
            else
            {
                reportForm.Activate();
            }
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// method that redirects user to report an issue/issues form.
        /// using a report form object.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reportIssuesBtn_Click(object sender, EventArgs e)
        {
            if (reportForm == null)
            {
                //initializing report object
                reportForm = new Reporting();
                //making the object an MDI parent
                reportForm.MdiParent = this;
                //filling the form and showing
                reportForm.Dock = DockStyle.Fill;
                reportForm.Show();
            }
            else
            {
                reportForm.Activate();
            }
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// menu strip user selects to exit.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// button that redirects user to events form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eventsBtn_Click(object sender, EventArgs e)
        {
            //Displaying sucess message
            MessageBox.Show("Maintanace mode. We will be back soon . ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// button that redirects user to announcements.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void announcementBtn_Click(object sender, EventArgs e)
        {
            //Displaying sucess message
            MessageBox.Show("Maintanace mode. We will be back soon . ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }//__________________________________________________________________________________________________________


        private void announcmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Displaying message
            MessageBox.Show("Maintanace mode. We will be back soon .", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }//__________________________________________________________________________________________________________
        

        private void localEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Displaying message
            MessageBox.Show("Maintanace mode. We will be back soon . ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }//__________________________________________________________________________________________________________


        private void serviceRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Displaying message
            MessageBox.Show("Maintanace mode. We will be back soon . ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }//__________________________________________________________________________________________________________

       
    }//_________________________________________________oooooEND OF FILEooooooo___________________________________________
}//_____________________________________________________________________________________________________________________________
