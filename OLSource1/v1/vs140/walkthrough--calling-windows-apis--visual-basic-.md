---
title: "Walkthrough: Calling Windows APIs (Visual Basic)"
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
  - "DLLs, calling"
  - "Windows API, walkthroughs"
  - "platform invoke, walkthroughs"
  - "API calls, walkthroughs [Visual Basic]"
  - "Windows API, calling"
  - "walkthroughs [Visual Basic], API calls"
  - "DllImport attribute, calling Windows API"
  - "Declare statement, declaring DLL functions"
ms.assetid: 9280ca96-7a93-47a3-8d01-6d01be0657cb
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Calling Windows APIs (Visual Basic)
Windows APIs are dynamic-link libraries (DLLs) that are part of the Windows operating system. You use them to perform tasks when it is difficult to write equivalent procedures of your own. For example, Windows provides a function named <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> that lets you make the title bar for an application alternate between light and dark shades.  
  
 The advantage of using Windows APIs in your code is that they can save development time because they contain dozens of useful functions that are already written and waiting to be used. The disadvantage is that Windows APIs can be difficult to work with and unforgiving when things go wrong.  
  
 Windows APIs represent a special category of interoperability. Windows APIs do not use managed code, do not have built-in type libraries, and use data types that are different than those used with Visual Studio. Because of these differences, and because Windows APIs are not COM objects, interoperability with Windows APIs and the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] is performed using platform invoke, or PInvoke. Platform invoke is a service that enables managed code to call unmanaged functions implemented in DLLs. For more information, see [Consuming Unmanaged DLL Functions](assetId:///eca7606e-ebfb-4f47-b8d9-289903fdc045). You can use PInvoke in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] by using either the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> statement or applying the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> attribute to an empty procedure.  
  
 Windows API calls were an important part of [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] programming in the past, but are seldom necessary with [!INCLUDE[vbprvblong](../vs140/includes/vbprvblong_md.md)]. Whenever possible, you should use managed code from the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] to perform tasks, instead of Windows API calls. This walkthrough provides information for those situations in which using Windows APIs is necessary.  
  
 [!INCLUDE[note_settings_general](../vs140/includes/note_settings_general_md.md)]  
  
## API Calls Using Declare  
 The most common way to call Windows APIs is by using the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> statement.  
  
#### To declare a DLL procedure  
  
1.  Determine the name of the function you want to call, plus its arguments, argument types, and return value, as well as the name and location of the DLL that contains it.  
  
    > [!NOTE]
    >  For complete information about the Windows APIs, see the Win32 SDK documentation in the Platform SDK Windows API. For more information about the constants that Windows APIs use, examine the header files such as Windows.h included with the Platform SDK.  
  
2.  Open a new Windows Application project by clicking **New** on the **File** menu, and then clicking **Project**. The **New Project** dialog box appears.  
  
3.  Select **Windows Application** from the list of [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] project templates. The new project is displayed.  
  
4.  Add the following <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function either to the class or module in which you want to use the DLL:  
  
     [!code[VbVbalrInterop#9](../vs140/codesnippet/VisualBasic/walkthrough--calling-windows-apis--visual-basic-_1.vb)]  
  
### Parts of the Declare Statement  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statement includes the following elements.  
  
#### Auto modifier  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> modifier instructs the runtime to convert the string based on the method name according to common language runtime rules (or alias name if specified).  
  
#### Lib and Alias keywords  
 The name following the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> keyword is the name your program uses to access the imported function. It can be the same as the real name of the function you are calling, or you can use any valid procedure name and then employ the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> keyword to specify the real name of the function you are calling.  
  
 Specify the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> keyword, followed by the name and location of the DLL that contains the function you are calling. You do not need to specify the path for files located in the Windows system directories.  
  
 Use the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> keyword if the name of the function you are calling is not a valid [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] procedure name, or conflicts with the name of other items in your application. <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> indicates the true name of the function being called.  
  
#### Argument and Data Type Declarations  
 Declare the arguments and their data types. This part can be challenging because the data types that Windows uses do not correspond to Visual Studio data types. [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] does a lot of the work for you by converting arguments to compatible data types, a process called *marshaling*. You can explicitly control how arguments are marshaled by using the \<xref:System.Runtime.InteropServices.MarshalAsAttribute*> attribute defined in the \<xref:System.Runtime.InteropServices*> namespace.  
  
> [!NOTE]
>  Previous versions of [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] allowed you to declare parameters <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, meaning that data of any data type could be used. [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] requires that you use a specific data type for all <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> statements.  
  
#### Windows API Constants  
 Some arguments are combinations of constants. For example, the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> API shown in this walkthrough accepts an integer argument called <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> that controls how the message box is displayed. You can determine the numeric value of these constants by examining the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> statements in the file WinUser.h. The numeric values are generally shown in hexadecimal, so you may want to use a calculator to add them and convert to decimal. For example, if you want to combine the constants for the exclamation style <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> 0x00000030 and the Yes/No style <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> 0x00000004, you can add the numbers and get a result of 0x00000034, or 52 decimal. Although you can use the decimal result directly, it is better to declare these values as constants in your application and combine them using the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> operator.  
  
###### To declare constants for Windows API calls  
  
1.  Consult the documentation for the Windows function you are calling. Determine the name of the constants it uses and the name of the .h file that contains the numeric values for these constants.  
  
2.  Use a text editor, such as Notepad, to view the contents of the header (.h) file, and find the values associated with the constants you are using. For example, the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> API uses the constant <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> to show a question mark in the message box. The definition for <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is in WinUser.h and appears as follows:  
  
     <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
3.  Add equivalent <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> statements to your class or module to make these constants available to your application. For example:  
  
     [!code[VbVbalrInterop#11](../vs140/codesnippet/VisualBasic/walkthrough--calling-windows-apis--visual-basic-_2.vb)]  
  
###### To call the DLL procedure  
  
1.  Add a button named <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> to the startup form for your project, and then double-click it to view its code. The event handler for the button is displayed.  
  
2.  Add code to the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> event handler for the button you added, to call the procedure and provide the appropriate arguments:  
  
     [!code[VbVbalrInterop#12](../vs140/codesnippet/VisualBasic/walkthrough--calling-windows-apis--visual-basic-_3.vb)]  
  
3.  Run the project by pressing F5. The message box is displayed with both **Yes** and **No** response buttons. Click either one.  
  
#### Data Marshaling  
 [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] automatically converts the data types of parameters and return values for Windows API calls, but you can use the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> attribute to explicitly specify unmanaged data types that an API expects. For more information about interop marshaling, see [Interop Marshaling](assetId:///115f7a2f-d422-4605-ab36-13a8dd28142a).  
  
###### To use Declare and MarshalAs in an API call  
  
1.  Determine the name of the function you want to call, plus its arguments, data types, and return value.  
  
2.  To simplify access to the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> attribute, add an <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> statement to the top of the code for the class or module, as in the following example:  
  
     [!code[VbVbalrInterop#13](../vs140/codesnippet/VisualBasic/walkthrough--calling-windows-apis--visual-basic-_4.vb)]  
  
3.  Add a function prototype for the imported function to the class or module you are using, and apply the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> attribute to the parameters or return value. In the following example, an API call that expects the type <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is marshaled as <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>:  
  
     [!code[VbVbalrInterop#14](../vs140/codesnippet/VisualBasic/walkthrough--calling-windows-apis--visual-basic-_5.vb)]  
  
## API Calls Using DllImport  
 The <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> attribute provides a second way to call functions in DLLs without type libraries. <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> is roughly equivalent to using a <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> statement but provides more control over how functions are called.  
  
 You can use <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> with most Windows API calls as long as the call refers to a shared (sometimes called *static*) method. You cannot use methods that require an instance of a class. Unlike <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> statements, <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> calls cannot use the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> attribute.  
  
#### To call a Windows API using the DllImport attribute  
  
1.  Open a new Windows Application project by clicking **New** on the **File** menu, and then clicking **Project**. The **New Project** dialog box appears.  
  
2.  Select **Windows Application** from the list of [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] project templates. The new project is displayed.  
  
3.  Add a button named <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> to the startup form.  
  
4.  Double-click <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> to open the code view for the form.  
  
5.  To simplify access to <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, add an <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> statement to the top of the code for the startup form class:  
  
     [!code[VbVbalrInterop#13](../vs140/codesnippet/VisualBasic/walkthrough--calling-windows-apis--visual-basic-_4.vb)]  
  
6.  Declare an empty function preceding the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> statement for the form, and name the function <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.  
  
7.  Apply the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> modifiers to the function declaration and set parameters for <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> based on the arguments the Windows API function uses:  
  
     [!code[VbVbalrInterop#16](../vs140/codesnippet/VisualBasic/walkthrough--calling-windows-apis--visual-basic-_6.vb)]  
  
     Your function can have any valid procedure name; the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> attribute specifies the name in the DLL. It also handles interoperability marshaling for the parameters and return values, so you can choose Visual Studio data types that are similar to the data types the API uses.  
  
8.  Apply the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> attribute to the empty function. The first parameter is the name and location of the DLL containing the function you are calling. You do not need to specify the path for files located in the Windows system directories. The second parameter is a named argument that specifies the name of the function in the Windows API. In this example, the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> attribute forces calls to <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> to be forwarded to <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> in KERNEL32.DLL. The <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> method copies a file from the path <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> to the path <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>.  
  
     [!code[VbVbalrInterop#17](../vs140/codesnippet/VisualBasic/walkthrough--calling-windows-apis--visual-basic-_7.vb)]  
  
9. Add code to the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> event handler to call the function:  
  
     [!code[VbVbalrInterop#18](../vs140/codesnippet/VisualBasic/walkthrough--calling-windows-apis--visual-basic-_8.vb)]  
  
10. Create a file named Test.txt and place it in the C:\Tmp directory on your hard drive. Create the Tmp directory if necessary.  
  
11. Press F5 to start the application. The main form appears.  
  
12. Click **Button2**. The message "The file was moved successfully" is displayed if the file can be moved.  
  
## See Also  
 \<xref:System.Runtime.InteropServices.DllImportAttribute*>   
 \<xref:System.Runtime.InteropServices.MarshalAsAttribute*>   
 [Declare Statement](../vs140/declare-statement.md)   
 [Auto](../vs140/auto--visual-basic-.md)   
 [Alias](../vs140/alias-clause--visual-basic-.md)   
 [COM Interop](../vs140/com-interop--visual-basic-.md)   
 [Creating Prototypes in Managed Code](assetId:///ecdcf25d-cae3-4f07-a2b6-8397ac6dc42d)   
 [Callback Sample](assetId:///6ddd7866-9804-4571-84de-83f5cc017a5a)