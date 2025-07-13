# DSA-in-Csharp
✅ Step-by-Step: Run C# File Using csc.exe
🔧 Step 1: Locate C# Compiler
Find the path to the compiler (csc.exe) on your machine:
   C:\Windows\Microsoft.NET\Framework64\v4.0.30319
🛠️ Step 2: Add Path to System Environment Variables
1.Press Win + S, type "Environment Variables", and open:

  Edit the system environment variables

2.In the System Properties window, click Environment Variables...

3.Under System Variables, find and select Path, then click Edit

4.Click New, then paste:
    C:\Windows\Microsoft.NET\Framework64\v4.0.30319
5.Click OK to close all dialogs

✅ Now you can access csc from any terminal window
📄 Step 3: Create a Simple C# File
Open Notepad or any code editor and save the following code as hello.cs:
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello from C#!");
    }
}
Make sure it’s saved with the .cs extension, not .txt.

💻 Step 4: Open Command Prompt
1.Press Win + R, type cmd, and press Enter

2.Navigate to the folder where hello.cs is saved.

⚙️ Step 5: Compile the C# File Using csc
    csc hello.cs
✅ This generates an executable file named hello.exe in the same folder.

▶️ Step 6: Run the Executable
   .\hello.exe
Output:
Hello from C#!
