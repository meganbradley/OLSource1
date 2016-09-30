---
title: "Walkthrough: Manipulating Files by Using .NET Framework Methods (Visual Basic)"
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
  - "I/O [Visual Basic], walkthroughs"
  - "text files, writing to"
  - "reading text files"
  - "text, writing to files"
  - "files, searching"
  - "StreamReader class, walkthroughs"
  - "files, accessing"
  - "I/O [Visual Basic], writing text to files"
  - "writing to files, walkthroughs"
  - "StreamWriter class, walkthroughs"
  - "text files, reading"
  - "I/O [Visual Basic], reading text from files"
ms.assetid: 7d2109eb-f98a-4389-b43d-30f384aaa7d5
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Manipulating Files by Using .NET Framework Methods (Visual Basic)
This walkthrough demonstrates how to open and read a file using the \<xref:System.IO.StreamReader*> class, check to see if a file is being accessed, search for a string within a file read with an instance of the \<xref:System.IO.StreamReader*> class, and write to a file using the \<xref:System.IO.StreamWriter*> class.  
  
 [!INCLUDE[note_settings_general](../vs140/includes/note_settings_general_md.md)]  
  
## Creating the Application  
 Start [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] and begin the project by creating a form that the user can use to write to the designated file.  
  
#### To create the project  
  
1.  On the **File** menu, select **New Project**.  
  
2.  In the **New Project** pane, click **Windows Application**.  
  
3.  In the **Name** box type <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> and click **OK**.  
  
     [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] adds the project to **Solution Explorer**, and the **Windows Forms Designer** opens.  
  
4.  Add the controls in the following table to the form and set the corresponding values for their properties.  
  
||||  
|-|-|-|  
|**Object**|**Properties**|**Value**|  
|\<xref:System.Windows.Forms.Button*>|**Name**\<br />\<br /> **Text**|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>\<br />\<br /> **Submit Entry**|  
|\<xref:System.Windows.Forms.Button*>|**Name**\<br />\<br /> **Text**|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>\<br />\<br /> **Clear Entry**|  
|\<xref:System.Windows.Forms.TextBox*>|**Name**\<br />\<br /> **Text**\<br />\<br /> **Multiline**|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>\<br />\<br /> **Please enter something.**\<br />\<br /> <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|  
  
## Writing to the File  
 To add the ability to write to a file via the application, use the \<xref:System.IO.StreamWriter*> class. \<xref:System.IO.StreamWriter*> is designed for character output in a particular encoding, whereas the \<xref:System.IO.Stream*> class is designed for byte input and output. Use \<xref:System.IO.StreamWriter*> for writing lines of information to a standard text file. For more information on the \<xref:System.IO.StreamWriter*> class, see \<xref:System.IO.StreamWriter*>.  
  
#### To add writing functionality  
  
1.  From the **View** menu, choose **Code** to open the Code Editor.  
  
2.  Because the application references the \<xref:System.IO*> namespace, add the following statements at the very beginning of your code, before the class declaration for the form, which begins <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
     [!code[VbVbcnMyFileSystem#35](../vs140/codesnippet/VisualBasic/walkthrough--manipulating-files-by-using-.net-framework-methods--visual-basic-_1.vb)]  
  
     Before writing to the file, you must create an instance of a \<xref:System.IO.StreamWriter*> class.  
  
3.  From the **View** menu, choose **Designer** to return to the **Windows Forms Designer**. Double-click the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> button to create a \<xref:System.Windows.Forms.Control.Click*> event handler for the button, and then add the following code.  
  
     [!code[VbVbcnMyFileSystem#36](../vs140/codesnippet/VisualBasic/walkthrough--manipulating-files-by-using-.net-framework-methods--visual-basic-_2.vb)]  
  
> [!NOTE]
>  The Visual Studio Integrated Development Environment (IDE) will return to the Code Editor and position the insertion point within the event handler where you should add the code.  
  
1.  To write to the file, use the \<xref:System.IO.StreamWriter.Write*> method of the \<xref:System.IO.StreamWriter*> class. Add the following code directly after <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. You do not need to worry that an exception will be thrown if the file is not found, because it will be created if it does not already exist.  
  
     [!code[VbVbcnMyFileSystem#37](../vs140/codesnippet/VisualBasic/walkthrough--manipulating-files-by-using-.net-framework-methods--visual-basic-_3.vb)]  
  
2.  Make sure that the user cannot submit a blank entry by adding the following code directly after <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
     [!code[VbVbcnMyFileSystem#38](../vs140/codesnippet/VisualBasic/walkthrough--manipulating-files-by-using-.net-framework-methods--visual-basic-_4.vb)]  
  
3.  Because this is a diary, the user will want to assign a date to each entry. Insert the following code after <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to set the variable <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to the current date.  
  
     [!code[VbVbcnMyFileSystem#39](../vs140/codesnippet/VisualBasic/walkthrough--manipulating-files-by-using-.net-framework-methods--visual-basic-_5.vb)]  
  
4.  Finally, attach code to clear the \<xref:System.Windows.Forms.TextBox*>. Add the following code to the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> button's \<xref:System.Windows.Forms.Control.Click*> event.  
  
     [!code[VbVbcnMyFileSystem#40](../vs140/codesnippet/VisualBasic/walkthrough--manipulating-files-by-using-.net-framework-methods--visual-basic-_6.vb)]  
  
## Adding Display Features to the Diary  
 In this section, you add a feature that displays the latest entry in the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>\<xref:System.Windows.Forms.TextBox*>. You can also add a \<xref:System.Windows.Forms.ComboBox*> that displays various entries and from which a user can select an entry to display in the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>\<xref:System.Windows.Forms.TextBox*>. An instance of the \<xref:System.IO.StreamReader*> class reads from <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. Like the \<xref:System.IO.StreamWriter*> class, \<xref:System.IO.StreamReader*> is intended for use with text files.  
  
 For this section of the walkthrough, add the controls in the following table to the form and set the corresponding values for their properties.  
  
|Control|Properties|Values|  
|-------------|----------------|------------|  
|\<xref:System.Windows.Forms.TextBox*>|**Name**\<br />\<br /> **Visible**\<br />\<br /> **Size**\<br />\<br /> **Multiline**|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|  
|\<xref:System.Windows.Forms.Button*>|**Name**\<br />\<br /> **Text**|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>\<br />\<br /> **Display**|  
|\<xref:System.Windows.Forms.Button*>|**Name**\<br />\<br /> **Text**|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>\<br />\<br /> **Get Entries**|  
|\<xref:System.Windows.Forms.ComboBox*>|**Name**\<br />\<br /> **Text**\<br />\<br /> **Enabled**|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>\<br />\<br /> **Select an Entry**\<br />\<br /> <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|  
  
#### To populate the combo box  
  
1.  The <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>\<xref:System.Windows.Forms.ComboBox*> is used to display the dates on which a user submits each entry, so the user can select an entry from a specific date. Create a \<xref:System.Windows.Forms.Control.Click*> event handler to the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> button and add the following code.  
  
     [!code[VbVbcnMyFileSystem#41](../vs140/codesnippet/VisualBasic/walkthrough--manipulating-files-by-using-.net-framework-methods--visual-basic-_7.vb)]  
  
2.  To test your code, press F5 to compile the application, and then click **Get Entries**. Click the drop-down arrow in the \<xref:System.Windows.Forms.ComboBox*> to display the entry dates.  
  
#### To choose and display individual entries  
  
1.  Create a \<xref:System.Windows.Forms.Control.Click*> event handler for the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> button and add the following code.  
  
     [!code[VbVbcnMyFileSystem#42](../vs140/codesnippet/VisualBasic/walkthrough--manipulating-files-by-using-.net-framework-methods--visual-basic-_8.vb)]  
  
2.  To test your code, press F5 to compile the application, and then submit an entry. Click **Get Entries**, select an entry from the \<xref:System.Windows.Forms.ComboBox*>, and then click **Display**. The contents of the selected entry appear in the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>\<xref:System.Windows.Forms.TextBox*>.  
  
## Enabling Users to Delete or Modify Entries  
 Finally, you can include additional functionality enables users to delete or modify an entry by using <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> buttons. Both buttons remain disabled unless an entry is displayed.  
  
 Add the controls in the following table to the form and set the corresponding values for their properties.  
  
|Control|Properties|Values|  
|-------------|----------------|------------|  
|\<xref:System.Windows.Forms.Button*>|**Name**\<br />\<br /> **Text**\<br />\<br /> **Enabled**|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>\<br />\<br /> **Delete Entry**\<br />\<br /> <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|  
|\<xref:System.Windows.Forms.Button*>|**Name**\<br />\<br /> **Text**\<br />\<br /> **Enabled**|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>\<br />\<br /> **Edit Entry**\<br />\<br /> <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|  
|\<xref:System.Windows.Forms.Button*>|**Name**\<br />\<br /> **Text**\<br />\<br /> **Enabled**|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>\<br />\<br /> **Submit Edit**\<br />\<br /> <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|  
  
#### To enable deletion and modification of entries  
  
1.  Add the following code to the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> button's \<xref:System.Windows.Forms.Control.Click*> event, after <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
     [!code[VbVbcnMyFileSystem#43](../vs140/codesnippet/VisualBasic/walkthrough--manipulating-files-by-using-.net-framework-methods--visual-basic-_9.vb)]  
  
2.  Create a \<xref:System.Windows.Forms.Control.Click*> event handler for the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> button and add the following code.  
  
     [!code[VbVbcnMyFileSystem#44](../vs140/codesnippet/VisualBasic/walkthrough--manipulating-files-by-using-.net-framework-methods--visual-basic-_10.vb)]  
  
3.  When a user displays an entry, the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> button becomes enabled. Add the following code to the \<xref:System.Windows.Forms.Control.Click*> event of the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> button after <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
     [!code[VbVbcnMyFileSystem#45](../vs140/codesnippet/VisualBasic/walkthrough--manipulating-files-by-using-.net-framework-methods--visual-basic-_11.vb)]  
  
4.  Create a \<xref:System.Windows.Forms.Control.Click*> event handler for the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> button and add the following code.  
  
     [!code[VbVbcnMyFileSystem#46](../vs140/codesnippet/VisualBasic/walkthrough--manipulating-files-by-using-.net-framework-methods--visual-basic-_12.vb)]  
  
5.  Create a \<xref:System.Windows.Forms.Control.Click*> event handler for the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> button and add the following code  
  
     [!code[VbVbcnMyFileSystem#47](../vs140/codesnippet/VisualBasic/walkthrough--manipulating-files-by-using-.net-framework-methods--visual-basic-_13.vb)]  
  
 To test your code, press F5 to compile the application. Click **Get Entries**, select an entry, and then click **Display**. The entry appears in the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>\<xref:System.Windows.Forms.TextBox*>. Click **Edit Entry**. The entry appears in the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>\<xref:System.Windows.Forms.TextBox*>. Edit the entry in the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>\<xref:System.Windows.Forms.TextBox*> and click **Submit Edit**. Open the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> file to confirm your correction. Now select an entry and click **Delete Entry**. When the \<xref:System.Windows.Forms.MessageBox*> requests confirmation, click **OK**. Close the application and open <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> to confirm the deletion.  
  
## See Also  
 \<xref:System.IO.StreamReader*>   
 \<xref:System.IO.StreamWriter*>   
 [Walkthroughs](../vs140/visual-basic-language-walkthroughs.md)