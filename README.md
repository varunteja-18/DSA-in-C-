# DSA-in-Csharp

---

## ✅ To **compile and run a standalone C# file** using the built-in `csc` (C# compiler) available in Windows.

---

### 🔧 Step 1: Add C# Compiler to System Path

1. Copy this path:

   ```
   C:\Windows\Microsoft.NET\Framework64\v4.0.30319
   ```
2. Open **System Environment Variables**:

   * Press `Win + S`, search for **"Environment Variables"**
   * Click on **"Edit the system environment variables"**
3. In the **System Properties** window:

   * Click **Environment Variables...**
   * Under **System variables**, select **Path** → click **Edit**
   * Click **New**, and paste the path above
   * Click **OK** on all dialogs to save

---

### 📄 Step 2: Create a `hello.cs` File

Create a file named `hello.cs` and paste the following code:

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello from C#!");
    }
}
```

Save it in any folder (e.g., Desktop).

---

### 💻 Step 3: Open Command Prompt and Navigate to the File Location

```bash
cd C:\Users\<YourName>\Desktop
```

Replace `<YourName>` with your actual Windows username or path where the file is saved.

---

### ⚙️ Step 4: Compile the C# File

```bash
csc hello.cs
```

This will generate an `hello.exe` file in the same folder.

---

### ▶️ Step 5: Run the Executable

```bash
.\hello.exe
```

You should see the output:

```
Hello from C#!
```

---




