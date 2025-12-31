# DragSequenceDemo

# DragSequenceDemo – Drag & Drop Ordering

This project demonstrates how to **reorder items using drag & drop** and save the sequence in the database.

---

## 🚀 Features
- Drag & drop ordering
- Save sequence to database
- Persist order after refresh

---

## 🧱 Tech Stack
- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- SortableJS

---

## 📁 Key Files
Models/Item.cs
Controllers/HomeController.cs
Views/Home/Index.cshtml


---

## ⚙️ Setup Steps

### 1️⃣ Seed Some Data
Add sample items manually or via DB.

### 2️⃣ Run Migrations
```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
▶️ Run Project

dotnet run
Open:

```
/Home/Index
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/4d30b27e-b2ce-4639-b33f-c1cdbb8adc2b" />




