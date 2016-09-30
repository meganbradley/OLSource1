---
title: "How to: Create the User Control and Host in a Dialog Box"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "get-started-article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MFC [C++], hosting a Windows Forms Control"
  - "Windows Forms [C++], MFC support"
ms.assetid: 03a53032-2f03-4fa2-b567-031615a26011
caps.latest.revision: 33
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Create the User Control and Host in a Dialog Box
The steps in this article assume that you are creating a dialog-based ([CDialog Class](../vs140/cdialog-class.md)) Microsoft Foundation Classes (MFC) project, but you can also add support for a Windows Forms control to an existing MFC dialog box.  
  
### To create the .NET user control  
  
1.  Create a Visual C# Windows Forms Control Library project named <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
     On the **File** menu, click **New** and then click **Project**. In the **Visual C#** folder, select **Windows Forms Control Library**.  
  
     Accept the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> project name by clicking **OK**.  
  
     By default, the name of the .NET control will be <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
2.  Add child controls to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
     In the **Toolbox**, open the **All Windows Forms** list. Drag a **Button** control to the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> design surface.  
  
     Also add a **TextBox** control.  
  
3.  In **Solution Explorer**, double-click **UserControl1.Designer.cs** to open it for editing. Change the declarations of the TextBox and the Button from <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
4.  Build the project.  
  
     On the **Build** menu, click **Build Solution**.  
  
### To create the MFC host application  
  
1.  Create an MFC Application project.  
  
     On the **File** menu, click **New** and then click **Project**. In the **Visual C++** folder, select **MFC Application**.  
  
     In the **Name** box, type <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. Change the Solution setting to **Add to Solution**. Click **OK**.  
  
     In the **MFC Application Wizard**, for Application Type, select **Dialog based**. Accept the remaining default settings and click **Finish**. This creates an MFC application that has an MFC dialog box.  
  
2.  Add a placeholder control to the MFC dialog box.  
  
     On the **View** menu, click **Resource View**. In **Resource View**, expand the **Dialog** folder and double-click <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. The dialog resource appears in **Resource Editor**.  
  
     In the **Toolbox**, open the **Dialog Editor** list. Drag a **Static Text** control to the dialog resource. The **Static Text** control will serve as a placeholder for the .NET Windows Forms control. Resize it to approximately the size of the Windows Forms control.  
  
     In the **Properties** window, change the **ID** of the **Static Text** control to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and change the **TabStop** property to **True**.  
  
3.  Configure the project for Common Language Runtime (CLR) support.  
  
     In **Solution Explorer**, right-click the MFC01 project node, and then click **Properties**.  
  
     In the **Property Pages** dialog box, under **Configuration Properties**, select **General**. In the **Project Defaults** section, set **Common Language Runtime support** to **Common Language Runtime Support (/clr)**.  
  
     Under **Configuration Properties**, expand **C/C++** and select the **General** node. Set **Debug Information Format** to **Program Database (/Zi)**.  
  
     Select the **Code Generation** node. Set **Enable Minimal Rebuild** to **No (/Gm-)**. Also set **Basic Runtime Checks** to **Default**.  
  
     Click **OK** to apply the changes.  
  
4.  Add a reference to the .NET control.  
  
     In **Solution Explorer**, right-click the MFC01 project node and then click **Add**, **References**. On the **Property Page**, click **Add New Reference**, select **WindowsFormsControlLibrary1** (under the **Projects** tab), and click **OK**. This adds a reference in the form of a [/FU](../vs140/-fu--name-forced-sharpusing-file-.md) compiler option so that the program will compile. It also puts a copy of WindowsFormsControlLibrary1.dll in the \MFC01\ project folder so that the program will run.  
  
5.  In Stdafx.h, find this line:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     Above it, add these lines:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
6.  Add code to create the managed control.  
  
     First, declare the managed control. In MFC01Dlg.h, go to the declaration of the dialog class, and add a data member for the user control in Protected scope, as follows.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     Next, provide an implementation for the managed control. In MFC01Dlg.cpp, in the dialog override of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> that was generated by the MFC Application wizard (not <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, which is in the same file), add the following code to create the managed control and associate it with the static place holder IDC_CTRL1.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
7.  Build and run the project.  
  
     In **Solution Explorer**, right-click **MFC01** and then click **Set as StartUp Project**.  
  
     On the **Build** menu, click **Build Solution**.  
  
     On the **Debug** menu, click **Start without debugging**. The MFC dialog box should display the Windows Forms control.  
  
## See Also  
 [Hosting a Windows Forms User Control in an MFC Dialog Box](../vs140/hosting-a-windows-form-user-control-in-an-mfc-dialog-box.md)