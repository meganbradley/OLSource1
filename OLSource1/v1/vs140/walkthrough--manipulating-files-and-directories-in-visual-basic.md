---
title: "Walkthrough: Manipulating Files and Directories in Visual Basic"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "files, reading text"
  - "reading files, text"
  - "I/O [Visual Basic], walkthroughs"
  - "text, writing to files"
  - "text, reading from files"
  - "reading text from files, walkthroughs"
  - "Visual Basic code, file access"
  - "files, writing text"
  - "I/O [Visual Basic], writing text to files"
  - "file access, walkthroughs"
  - "writing to files, walkthroughs"
  - "I/O [Visual Basic], reading text from files"
ms.assetid: cae77565-9f78-4e46-8e42-eb2f9f8e1ffd
caps.latest.revision: 53
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Manipulating Files and Directories in Visual Basic
This walkthrough provides an introduction to the fundamentals of file I/O in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)]. It describes how to create a small application that lists and examines text files in a directory. For each selected text file, the application provides file attributes and the first line of content. There is an option to write information to a log file.  
  
 This walkthrough uses members of the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, which are available in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)]. See \<xref:Microsoft.VisualBasic.FileIO.FileSystem*> for more information. At the end of the walkthrough, an equivalent example is provided that uses classes from the \<xref:System.IO*> namespace.  
  
 [!INCLUDE[note_settings_general](../vs140/includes/note_settings_general_md.md)]  
  
### To create the project  
  
1.  On the **File** menu, click **New Project**.  
  
     The **New Project** dialog box appears.  
  
2.  In the **Installed Templates** pane, expand **Visual Basic**, and then click **Windows**. In the **Templates** pane in the middle, click **Windows Forms Application**.  
  
3.  In the **Name** box, type <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to set the project name, and then click **OK**.  
  
     [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] adds the project to **Solution Explorer**, and the Windows Forms Designer opens.  
  
4.  Add the controls in the following table to the form, and set the corresponding values for their properties.  
  
    |Control|Property|Value|  
    |-------------|--------------|-----------|  
    |**ListBox**|**Name**|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|  
    |**Button**|**Name**\<br />\<br /> **Text**|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>\<br />\<br /> **Browse**|  
    |**Button**|**Name**\<br />\<br /> **Text**|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>\<br />\<br /> **Examine**|  
    |**CheckBox**|**Name**\<br />\<br /> **Text**|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>\<br />\<br /> **Save Results**|  
    |**FolderBrowserDialog**|**Name**|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|  
  
### To select a folder, and list files in a folder  
  
1.  Create a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> event handler for <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> by double-clicking the control on the form. The Code Editor opens.  
  
2.  Add the following code to the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> event handler.  
  
     [!code[VbVbcnMyFileSystem#103](../vs140/codesnippet/VisualBasic/walkthrough--manipulating-files-and-directories-in-visual-basic_1.vb)]  
  
     The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> call opens the **Browse For Folder** dialog box. After the user clicks **OK**, the \<xref:System.Windows.Forms.FolderBrowserDialog.SelectedPath*> property is sent as an argument to the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> method, which is added in the next step.  
  
3.  Add the following <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> method.  
  
     [!code[VbVbcnMyFileSystem#104](../vs140/codesnippet/VisualBasic/walkthrough--manipulating-files-and-directories-in-visual-basic_2.vb)]  
  
     This code first clears the **ListBox**.  
  
     The \<xref:Microsoft.VisualBasic.FileIO.FileSystem.GetFiles*> method then retrieves a collection of strings, one for each file in the directory. The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> method accepts a search pattern argument to retrieve files that match a particular pattern. In this example, only files that have the extension .txt are returned.  
  
     The strings that are returned by the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> method are then added to the **ListBox**.  
  
4.  Run the application. Click the **Browse** button. In the **Browse For Folder** dialog box, browse to a folder that contains .txt files, and then select the folder and click **OK**.  
  
     The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> contains a list of .txt files in the selected folder.  
  
5.  Stop running the application.  
  
### To obtain attributes of a file, and content from a text file  
  
1.  Create a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> event handler for <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> by double-clicking the control on the form.  
  
2.  Add the following code to the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> event handler.  
  
     [!code[VbVbcnMyFileSystem#105](../vs140/codesnippet/VisualBasic/walkthrough--manipulating-files-and-directories-in-visual-basic_3.vb)]  
  
     The code verifies that an item is selected in the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. It then obtains the file path entry from the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. The \<xref:Microsoft.VisualBasic.FileIO.FileSystem.FileExists*> method is used to check whether the file still exists.  
  
     The file path is sent as an argument to the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> method, which is added in the next step. This method returns a string that contains file information. The file information appears in a **MessageBox**.  
  
3.  Add the following <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> method.  
  
     [!code[VbVbcnMyFileSystem#107](../vs140/codesnippet/VisualBasic/walkthrough--manipulating-files-and-directories-in-visual-basic_4.vb)]  
  
     The code uses the \<xref:Microsoft.VisualBasic.FileIO.FileSystem.GetFileInfo*> method to obtain file parameters. The file parameters are added to a \<xref:System.Text.StringBuilder*>.  
  
     The \<xref:Microsoft.VisualBasic.FileIO.FileSystem.OpenTextFileReader*> method reads the file contents into a \<xref:System.IO.StreamReader*>. The first line of the contents is obtained from the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and is added to the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
4.  Run the application. Click **Browse**, and browse to a folder that contains .txt files. Click **OK**.  
  
     Select a file in the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, and then click **Examine**. A <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> shows the file information.  
  
5.  Stop running the application.  
  
### To add a log entry  
  
1.  Add the following code to the end of the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> event handler.  
  
     [!code[VbVbcnMyFileSystem#106](../vs140/codesnippet/VisualBasic/walkthrough--manipulating-files-and-directories-in-visual-basic_5.vb)]  
  
     The code sets the log file path to put the log file in the same directory as that of the selected file. The text of the log entry is set to the current date and time followed by the file information.  
  
     The \<xref:Microsoft.VisualBasic.FileIO.FileSystem.WriteAllText*> method, with the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> argument set to <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, is used to create the log entry.  
  
2.  Run the application. Browse to a text file, select it in the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, select the **Save Results** check box, and then click **Examine**. Verify that the log entry is written to the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> file.  
  
3.  Stop running the application.  
  
### To use the current directory  
  
1.  Create an event handler for <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> by double-clicking the form.  
  
2.  Add the following code to the event handler.  
  
     [!code[VbVbcnMyFileSystem#102](../vs140/codesnippet/VisualBasic/walkthrough--manipulating-files-and-directories-in-visual-basic_6.vb)]  
  
     This code sets the default directory of the folder browser to the current directory.  
  
3.  Run the application. When you click **Browse** the first time, the **Browse For Folder** dialog box opens to the current directory.  
  
4.  Stop running the application.  
  
### To selectively enable controls  
  
1.  Add the following <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> method.  
  
     [!code[VbVbcnMyFileSystem#108](../vs140/codesnippet/VisualBasic/walkthrough--manipulating-files-and-directories-in-visual-basic_7.vb)]  
  
     The <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> method enables or disables controls depending on whether an item is selected in the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.  
  
2.  Create a <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> event handler for <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> by double-clicking the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> control on the form.  
  
3.  Add a call to <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> in the new <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> event handler.  
  
4.  Add a call to <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> at the end of the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> event handler.  
  
5.  Add a call to <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> at the end of the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> event handler.  
  
6.  Run the application. The **Save Results** check box and the **Examine** button are disabled if an item is not selected in the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.  
  
## Full example using My.Computer.FileSystem  
 Following is the complete example.  
  
 [!code[VbVbcnMyFileSystem#101](../vs140/codesnippet/VisualBasic/walkthrough--manipulating-files-and-directories-in-visual-basic_8.vb)]  
  
## Full example using System.IO  
 The following equivalent example uses classes from the \<xref:System.IO*> namespace instead of using <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> objects.  
  
 [!code[VbVbcnMyFileSystem#111](../vs140/codesnippet/VisualBasic/walkthrough--manipulating-files-and-directories-in-visual-basic_9.vb)]  
  
## See Also  
 \<xref:System.IO*>   
 \<xref:Microsoft.VisualBasic.FileIO.FileSystem*>   
 \<xref:Microsoft.VisualBasic.FileIO.FileSystem.CurrentDirectory*>   
 [Walkthrough: Manipulating Files by Using .NET Framework Methods (Visual Basic)](../vs140/walkthrough--manipulating-files-by-using-.net-framework-methods--visual-basic-.md)