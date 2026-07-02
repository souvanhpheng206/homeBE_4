

# 📂 FileProcessing - Data Filtering & Validation

โปรเจกต์นี้เป็นโปรแกรม Windows Forms Application (C#) สำหรับการอ่านและประมวลผลไฟล์ข้อมูลขนาดใหญ่ (เช่น `.csv` และ `.txt`) โดยมีฟีเจอร์หลักในการจำกัดจำนวนแถวที่ต้องการอ่านและกรองข้อมูล (Filtering) เพื่อป้องกันปัญหาหน่วยความจำ (RAM) เต็ม และเพิ่มประสิทธิภาพในการแสดงผล

## 🚀 ฟีเจอร์หลัก (Features & Test Cases)
โปรแกรมนี้ได้ผ่านการทดสอบตาม Test Plan จำนวน 5 กรณี ดังนี้:

1. **Partial Loading (จำกัดช่วงข้อมูล):** สามารถระบุ `StartRow` และ `EndRow` เพื่อดึงข้อมูลมาแสดงผลเฉพาะช่วงที่ต้องการได้ (เช่น โหลดแค่แถวที่ 1-30)
2. **Invalid Range Validation (ป้องกันข้อผิดพลาด):** มีระบบแจ้งเตือน (MessageBox) และดักจับ Error กรณีผู้ใช้กรอกช่วงแถวผิดพลาด (เช่น EndRow น้อยกว่า StartRow)
3. **Data Filtering (กรองข้อมูล):** สามารถระบุคำ (Keyword) ในช่อง Filter เพื่อค้นหาและแสดงผลเฉพาะแถวที่มีคำนั้นๆ ได้ (เช่น กรองหาคำว่า `exe`)
4. **Combined Condition (เงื่อนไขร่วม - Bonus):** สามารถจำกัดช่วงแถว (Range) และกรองคำ (Filter) ไปพร้อมๆ กันได้อย่างสมบูรณ์แบบ
5. **Text UI Validation:** รองรับการอ่านไฟล์หน้าแท็บ Text แบบจำกัดแถว โดยไม่มีปัญหา UI ซ้อนทับกัน (RichTextBox ไม่ทับปุ่มควบคุม)

## 🛠️ สภาพแวดล้อมที่ใช้ทดสอบ (Environment)
* **OS:** Windows 11
* **Language:** C# (.NET Framework / Windows Forms)
* **Test Data Set:** `malware_500.csv`

## 👨‍💻 ผู้จัดทำ
**Souvanhpheng Sydavong**
(อัปโหลดโปรเจกต์)
