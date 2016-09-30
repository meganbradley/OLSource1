---
title: "Walkthrough: Persisting an Object in Visual Studio (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "get-started-article"
dev_langs: 
  - "VB"
ms.assetid: f1d0b562-e349-4dce-ab5f-c05108467030
caps.latest.revision: 7
---
# Walkthrough: Persisting an Object in Visual Studio (Visual Basic)
Although you can set an object's properties to default values at design time, any values entered at run time are lost when the object is destroyed. You can use serialization to persist an object's data between instances, which enables you to store values and retrieve them the next time that the object is instantiated.  
  
> [!NOTE]
>  In Visual Basic, to store simple data, such as a name or number, you can use the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object. For more information, see [My.Settings Object](../vs140/my.settings-object.md).  
  
 In this walkthrough, you will create a simple <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object and persist its data to a file. You will then retrieve the data from the file when you re-create the object.  
  
> [!IMPORTANT]
>  This example creates a new file, if the file does not already exist. If an application must create a file, that application must <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> permission for the folder. Permissions are set by using access control lists. If the file already exists, the application needs only <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> permission, a lesser permission. Where possible, it is more secure to create the file during deployment, and only grant <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> permissions to a single file (instead of Create permissions for a folder). Also, it is more secure to write data to user folders than to the root folder or the Program Files folder.  
  
> [!IMPORTANT]
>  This example stores data in a binary. These formats should not be used for sensitive data, such as passwords or credit-card information.  
  
> [!NOTE]
>  The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, click **Import and Export Settings** on the **Tools** menu. For more information, see [Customizing Development Settings in Visual Studio](assetId:///22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
## Creating the Loan Object  
 The first step is to create a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> class and a test application that uses the class.  
  
#### To create the Loan class  
  
1.  Create a new Class Library project and name it "LoanClass". For more information, see [How to: Create Solutions and Projects](../vs140/creating-solutions-and-projects.md).  
  
2.  In **Solution Explorer**, open the shortcut menu for the Class1 file and choose **Rename**. Rename the file to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and press ENTER. Renaming the file will also rename the class to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
3.  Add the following public members to the class:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 You will also have to create a simple application that uses the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> class.  
  
#### To create a test application  
  
1.  To add a Windows Forms Application project to your solution, on the **File** menu, choose **Add**,**New Project**.  
  
2.  In the **Add New Project** dialog box, choose **Windows Forms Application**, and enter <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> as the name of the project, and then click **OK** to close the dialog box.  
  
3.  In **Solution Explorer**, choose the LoanApp project.  
  
4.  On the **Project** menu, choose **Set as StartUp Project**.  
  
5.  On the **Project** menu, choose **Add Reference**.  
  
6.  In the **Add Reference** dialog box, choose the **Projects** tab and then choose the LoanClass project.  
  
7.  Click **OK** to close the dialog box.  
  
8.  In the designer, add four \<xref:System.Windows.Forms.TextBox*> controls to the form.  
  
9. In the Code Editor, add the following code:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
10. Add an event handler for the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> event to the form by using the following code:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 At this point, you can build and run the application. Note that the default values from the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> class appear in the text boxes. Try to change the interest-rate value from 7.5 to 7.1, and then close the application and run it again—the value reverts to the default of 7.5.  
  
 In the real world, interest rates change periodically, but not necessarily every time that the application is run. Rather than making the user update the interest rate every time that the application runs, it is better to preserve the most recent interest rate between instances of the application. In the next step, you will do just that by adding serialization to the Loan class.  
  
## Using Serialization to Persist the Object  
 In order to persist the values for the Loan class, you must first mark the class with the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> attribute.  
  
#### To mark a class as serializable  
  
-   Change the class declaration for the Loan class as follows:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> attribute tells the compiler that everything in the class can be persisted to a file. Because the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> event is handled by a Windows Form object, it cannot be serialized. The <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> attribute can be used to mark class members that should not be persisted.  
  
#### To prevent a member from being serialized  
  
-   Change the declaration for the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> event as follows:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The next step is to add the serialization code to the LoanApp application. In order to serialize the class and write it to a file, you will use the \<xref:System.IO*> and \<xref:System.Xml.Serialization*> namespaces. To avoid typing the fully qualified names, you can add references to the necessary class libraries.  
  
#### To add references to namespaces  
  
-   Add the following statements to the top of the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> class:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
     In this case, you are using a binary formatter to save the object in a binary format.  
  
 The next step is to add code to deserialize the object from the file when the object is created.  
  
#### To deserialize an object  
  
1.  Add a constant to the class for the serialized data's file name.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
2.  Modify the code in the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> event procedure as follows:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
     Note that you first must check that the file exists. If it exists, create a \<xref:System.IO.Stream*> class to read the binary file and a \<xref:System.Runtime.Serialization.Formatters.Binary.BinaryFormatter*> class to translate the file. You also need to convert from the stream type to the Loan object type.  
  
 Next you must add code to save the data entered in the text boxes to the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> class, and then you must serialize the class to a file.  
  
#### To save the data and serialize the class  
  
-   Add the following code to the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> event procedure:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 At this point, you can again build and run the application. Initially, the default values appear in the text boxes. Try to change the values and enter a name in the fourth text box. Close the application and then run it again. Note that the new values now appear in the text boxes.  
  
## See Also  
 [Serialization (Visual Basic)](../vs140/serialization--visual-basic-.md)   
 [Visual Basic Programming Guide](../vs140/visual-basic-programming-guide.md)