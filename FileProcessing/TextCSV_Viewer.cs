/*
MIT License

Copyright (c) 2026 Sarayut Chaisuriya

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

// ... (ตัดส่วนลิขสิทธิ์ออกนิดหน่อยเพื่อให้สั้นลงตอนแสดงผล แต่ในโค้ดจริงมีครบครับ)
*/
using System;
using System.IO;
using System.Windows.Forms;

namespace FileProcessing
{
    public partial class frmTextView : Form
    {
        /// <summary>
        /// Initializes a new instance of the frmTextView class.
        /// </summary>
        public frmTextView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the Read button by loading the contents of the specified file into the display area.
        /// </summary>
        private void btRead_Click(object sender, EventArgs e)
        {
            // ล้างกล่องข้อความเก่าก่อนโชว์ข้อมูลใหม่
            rtbShow.Clear();

            int startRow = 1;
            int endRow = int.MaxValue;
            string fileTypeFilter = tbFilter.Text.Trim().ToLower(); // ดึงค่าจากช่องกรองของฝั่ง Text

            // ตรวจสอบเงื่อนไขช่วงแถว (m ถึง n)
            if (!string.IsNullOrWhiteSpace(tbStartRow.Text) && !string.IsNullOrWhiteSpace(tbEndRow.Text))
            {
                if (int.TryParse(tbStartRow.Text, out int m) && int.TryParse(tbEndRow.Text, out int n))
                {
                    if (n < m)
                    {
                        MessageBox.Show("กรุณากรอกช่วงข้อมูลให้ถูกต้อง (ค่าสิ้นสุด n ต้องไม่น้อยกว่าค่าเริ่มต้น m)",
                                        "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    startRow = m;
                    endRow = n;
                }
            }

            // อ่านไฟล์ Text แบบ Stream ทีละบรรทัดมาแสดงผล
            using (StreamReader srReader = new StreamReader(tbFileName.Text))
            {
                string strLine;
                int dataRowCounter = 0;

                while ((strLine = srReader.ReadLine()) != null)
                {
                    // ข้ามบรรทัดที่เป็น Comment
                    if (strLine.StartsWith("#"))
                    {
                        continue;
                    }

                    dataRowCounter++; // นับแถวข้อมูลจริง

                    // เช็กเงื่อนไขช่วงแถว m ถึง n
                    if (dataRowCounter >= startRow && dataRowCounter <= endRow)
                    {
                        // เช็กเงื่อนไขการกรองคำ (Filter)
                        bool matchesFilter = string.IsNullOrEmpty(fileTypeFilter) ||
                                             strLine.ToLower().Contains(fileTypeFilter);

                        if (matchesFilter)
                        {
                            // เพิ่มข้อมูลทีละบรรทัดลงใน RichTextBox
                            rtbShow.AppendText(strLine + Environment.NewLine);
                        }
                    }

                    // เพื่อความเร็ว: ถ้าอ่านเกินแถวที่ต้องการแล้ว และไม่ได้กรองข้อมูล ก็หยุดอ่านได้เลย
                    if (dataRowCounter > endRow && string.IsNullOrEmpty(fileTypeFilter))
                    {
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the btReadCSV button, reading CSV data from the specified file and populating the
        /// DataGridView with its contents.
        /// </summary>
        private void btReadCSV_Click(object sender, EventArgs e)
        {
            // ล้างตารางเก่าก่อนโหลดข้อมูลใหม่ทุกครั้ง
            dgvData.Rows.Clear();
            dgvData.Columns.Clear();

            int startRow = 1;
            int endRow = int.MaxValue;
            string fileTypeFilter = tbFilterCsv.Text.Trim().ToLower(); // ดึงค่าจากช่องกรอง CSV

            // ตรวจสอบเงื่อนไขช่วงแถว (m ถึง n)
            if (!string.IsNullOrWhiteSpace(tbStartRowCsv.Text) && !string.IsNullOrWhiteSpace(tbEndRowCsv.Text))
            {
                if (int.TryParse(tbStartRowCsv.Text, out int m) && int.TryParse(tbEndRowCsv.Text, out int n))
                {
                    if (n < m)
                    {
                        MessageBox.Show("กรุณากรอกช่วงข้อมูลให้ถูกต้อง (ค่าสิ้นสุด n ต้องไม่น้อยกว่าค่าเริ่มต้น m)",
                                        "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    startRow = m;
                    endRow = n;
                }
            }

            using (StreamReader srReader = new StreamReader(tbFileName.Text))
            {
                string strLine; // Variable to hold each line read from the file
                bool bHeaderRead = false;   // Flag to indicate whether the header line has been read
                int dataRowCounter = 0;     // ตัวนับจำนวนแถวข้อมูลจริง

                // Main loop: Read the file line by line
                while ((strLine = srReader.ReadLine()) != null)
                {
                    string[] strHeaders_arr = null;
                    // Skip comment lines and check for header line
                    if (strLine.StartsWith("#"))
                    {
                        if (strLine.Length > 8 && strLine.Substring(0, 8).Equals("#HEADER"))
                        {
                            // Read the header line and split it into an array of headers
                            strHeaders_arr = strLine.Substring(8).Split(',');
                        }
                        continue;
                    }
                    // Split the current line into an array of values
                    string[] strValues_arr = strLine.Split(',');

                    // If the header has not been read yet, add the headers to the DataGridView columns
                    if (!bHeaderRead)
                    {
                        // Add the headers to the DataGridView columns, using the header names from the header line if available
                        foreach (string strHeader in strValues_arr)
                        {
                            if (strHeaders_arr == null)
                                dgvData.Columns.Add(strHeader.Trim(), strHeader.Trim());
                            else
                                dgvData.Columns.Add(strHeader.Trim(), strHeaders_arr[dgvData.Columns.Count].Trim());
                        }
                        bHeaderRead = true;
                        continue;
                    }

                    // --- เริ่มประมวลผลข้อมูลจริง (Partial Loading & Filter) ---
                    dataRowCounter++;

                    // เช็กว่าแถวนี้อยู่ในช่วง m ถึง n ที่ต้องการหรือไม่
                    if (dataRowCounter >= startRow && dataRowCounter <= endRow)
                    {
                        // เช็กว่าแถวนี้มีคำที่ต้องการค้นหา (Filter) หรือไม่
                        bool matchesFilter = string.IsNullOrEmpty(fileTypeFilter) ||
                                             Array.Exists(strValues_arr, val => val.Trim().ToLower().Contains(fileTypeFilter));

                        if (matchesFilter)
                        {
                            dgvData.Rows.Add(strValues_arr); // เพิ่มข้อมูลลงตาราง
                        }
                    }

                    // หยุดอ่านถ้าเลยช่วงแถวสิ้นสุด (n) แล้ว และไม่ได้พิมพ์กรองอะไร เพื่อลดการทำงานของแรม
                    if (dataRowCounter > endRow && string.IsNullOrEmpty(fileTypeFilter))
                    {
                        break;
                    }
                }   // Main loop: Read the file line by line
            }
        }

        /// <summary>
        /// Handles the Click event of the Browse button, allowing the user to select a file and displaying its path in the
        /// file name text box.
        /// </summary>
        private void btBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Text Files (*.txt)|*.txt|CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    tbFileName.Text = ofd.FileName;
                }
            }
        }

        // --- ส่วนที่โปรแกรมสร้างให้อัตโนมัติ (ห้ามลบ) ---
        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void tbStartRow_TextChanged(object sender, EventArgs e)
        {
        }

        private void rtbShow_TextChanged(object sender, EventArgs e)
        {
        }
    }   // End of frmTextView class
} // <--- ผมเติมปีกกาปิดตัวที่ขาดหายไปให้ตรงนี้เรียบร้อยครับ!