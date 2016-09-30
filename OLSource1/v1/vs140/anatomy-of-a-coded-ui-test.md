---
title: "Anatomy of a Coded UI Test"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "coded UI tests"
ms.assetid: 9c5d82fc-3fb7-4bb1-a9ac-ac1fa3a4b500
caps.latest.revision: 27
ms.author: "mlearned"
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Anatomy of a Coded UI Test
When you create a Coded UI Test in a coded UI test project, several files are added to your solution. In this topic, we will use an example Coded UI Test to explore these files.  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
## Contents of a Coded UI Test  
 When you create a Coded UI Test, the **Coded UI Test Builder** creates a map of the user interface under test, and also the test methods, parameters, and assertions for all tests. It also creates a class file for each test.  
  
|File|Contents|Editable?|  
|----------|--------------|---------------|  
|[UIMap.Designer.cs](#UIMapDesignerFile)|[Declarations section](#UIMapDesignerFile)\<br />\<br /> [UIMap class](#UIMapClass) (partial, auto-generated)\<br />\<br /> [Methods](#UIMapMethods)\<br />\<br /> [Properties](#UIMapProperties)|No|  
|[UIMap.cs](#UIMapCS)|[UIMap class](#UIMapCS) (partial)|Yes|  
|[CodedUITest1.cs](#CodedUITestCS)|[CodedUITest1 class](#CodedUITestCS)\<br />\<br /> [Methods](#CodedUITestMethods)\<br />\<br /> [Properties](#CodedUITestProperties)|Yes|  
|[UIMap.uitest](#UIMapuitest)|The XML map of the UI for the test.|No|  
  
###  \<a name="UIMapDesignerFile">\</a> UIMap.Designer.cs  
 This file contains code that is automatically created by the **Coded UI Test Builder** when a test is created. This file is re-created every time that a test changes, so that it is not a file in which you can add or modify code.  
  
#### Declarations section  
 This section includes the following declarations for a Windows UI.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The \<xref:Microsoft.VisualStudio.TestTools.UITesting.WinControls*> namespace is included for a Windows user interface (UI). For a Web page UI, the namespace would be \<xref:Microsoft.VisualStudio.TestTools.UITesting.HtmlControls*>; for a Windows Presentation Foundation UI, the namespace would be \<xref:Microsoft.VisualStudio.TestTools.UITesting.WpfControls*>.  
  
####  \<a name="UIMapClass">\</a> UIMap class  
 The next section of the file is the \<xref:Microsoft.VisualStudio.TestTools.UITest.Common.UIMap.UIMap*> class.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The class code starts with a \<xref:System.CodeDom.Compiler.GeneratedCodeAttribute*> that is applied to the class, which is declared as a partial class. You will notice that the attribute is also applied to every class in this file. The other file that can contain more code for this class is <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, which is discussed later.  
  
 The generated <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> class includes code for each method that was specified when the test was recorded.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This part of the \<xref:Microsoft.VisualStudio.TestTools.UITest.Common.UIMap.UIMap*> class also includes the generated code for each property that is required by the methods.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
#####  \<a name="UIMapMethods">\</a> UIMap methods  
 Each method has a structure that resembles the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> method. This is explained in more detail under the code, which is presented together with line breaks to add clarity.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The summary comment for each method definition tells which class to use for parameter values for that method. In this case, it is the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> class, which is defined later in the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> file, and which is also the value type that is returned by the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> property.  
  
 At the top of the method code is a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> region that defines local variables for the UI objects that will be used by the method.  
  
 In this method, both <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> are properties that are accessed by using the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> class, which is defined later in the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> file.  
  
 Next are lines that send text from the keyboard to the Calculator application by using properties of the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object.  
  
 The <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> method has a very similar structure, and includes the following assertion code.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The text box name is listed as unknown because the developer of the Windows Calculator application did not provide a publicly available name for the control. The \<xref:Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual*?displayProperty=fullName> method fails when the actual value is not equal to the expected value, which would cause the test to fail. Also notice that the expected value includes a decimal point that is followed by a space. If you ever have to modify the functionality of this particular test, you must allow for that decimal point and the space.  
  
#####  \<a name="UIMapProperties">\</a> UIMap properties  
 The code for each property is also very standard throughout the class. The following code for the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> property is used in the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> method.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Notice that the property uses a private local variable that is named <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> to hold the value before it returns it. The property name and the class name for the object it returns are the same. The class is defined later in the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> file.  
  
 Each class that is returned by a property is structured similarly. The following is the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> class.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 As with all classes in the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> file, this class starts with the \<xref:System.CodeDom.Compiler.GeneratedCodeAttribute*>. In this small class is a <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> region that defines the strings to use as parameters for the \<xref:Microsoft.VisualStudio.TestTools.UITesting.Keyboard.SendKeys*?displayProperty=fullName> method that is used in the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> method that was discussed earlier. You can write code to replace the values in these string fields before the method in which these parameters are used is called.  
  
###  \<a name="UIMapCS">\</a> UIMap.cs  
 By default, this file contains a partial <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> class that has no methods or properties.  
  
#### UIMap class  
 This is where you can create custom code to extend the functionality of the \<xref:Microsoft.VisualStudio.TestTools.UITest.Common.UIMap.UIMap*> class. The code that you create in this file will not be regenerated by the **Coded UI Test Builder** every time that a test is modified.  
  
 All parts of the \<xref:Microsoft.VisualStudio.TestTools.UITest.Common.UIMap.UIMap*> can use the methods and properties from any other part of the \<xref:Microsoft.VisualStudio.TestTools.UITest.Common.UIMap.UIMap*> class.  
  
###  \<a name="CodedUITestCS">\</a> CodedUITest1.cs  
 This file is generated by the **Coded UI Test Builder**, but is not re-created every time that the test is modified, so that you can modify the code in this file. The name of the file is generated from the name that you specified for the test when you created it.  
  
#### CodedUITest1 class  
 By default, this file contains the definition for only one class.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The T:Microsoft.VisualStudio.TestTools.UITesting.CodedUITestAttribute is automatically applied to the class, which allows the testing framework to recognize it as a testing extension. Also notice that this is not a partial class. All class code is contained in this file.  
  
#####  \<a name="CodedUITestProperties">\</a> CodedUITest1 properties  
 The class contains two default properties that are located at the bottom of the file. They must not be modified.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
#####  \<a name="CodedUITestMethods">\</a> CodedUITest1 methods  
 By default, the class contains only one method.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 This method calls each <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> method that you specified when you recorded your test, which is described in the section on the [UIMap Class](#UIMapClass).  
  
 A region that is titled <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, if uncommented, contains two optional methods.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> method has the \<xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute*> applied to it, which tells the testing framework to call this method before any other test methods. Similarly, the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> method has the \<xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute*> applied to it, which tells the testing framework to call this method after all other test methods have been called. Use of these methods is optional. For this test, the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> method could be called from <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> and the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> method could be called from <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> instead of from <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.  
  
 If you add more methods to this class by using the \<xref:Microsoft.VisualStudio.TestTools.UITesting.CodedUITestAttribute*>, the testing framework will call each method as part of the test.  
  
###  \<a name="UIMapuitest">\</a> UIMap.uitest  
 This is an XML file that represents the structure of the coded UI test recording and all its parts. These include the actions and the classes in addition to the methods and properties of those classes. The [UIMap.Designer.cs](#UIMapDesignerFile) file contains the code that is generated by the Coded UI Builder to reproduce the structure of the test and provides the connection to the testing framework.  
  
 The <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> file is not directly editable. However, you can use the Coded UI Builder to modify the test, which automatically modifies the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> file and the [UIMap.Designer.cs](#UIMapDesignerFile) file.  
  
## See Also  
 \<xref:Microsoft.VisualStudio.TestTools.UITest.Common.UIMap.UIMap*>   
 \<xref:Microsoft.VisualStudio.TestTools.UITesting.WinControls*>   
 \<xref:Microsoft.VisualStudio.TestTools.UITesting.HtmlControls*>   
 \<xref:Microsoft.VisualStudio.TestTools.UITesting.WpfControls*>   
 \<xref:System.CodeDom.Compiler.GeneratedCodeAttribute*>   
 \<xref:Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual*?displayProperty=fullName>   
 \<xref:Microsoft.VisualStudio.TestTools.UITesting.Keyboard.SendKeys*?displayProperty=fullName>   
 \<xref:Microsoft.VisualStudio.TestTools.UITesting.CodedUITestAttribute*>   
 \<xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute*>   
 \<xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute*>   
 [Verifying Code by Using Coded User Interface Tests](../vs140/use-ui-automation-to-test-your-code.md)   
 [Creating Coded UI Tests](../vs140/use-ui-automation-to-test-your-code.md#VerifyingCodeUsingCUITCreate)   
 [Best Practices for Coded UI Tests](../vs140/best-practices-for-coded-ui-tests.md)   
 [Testing a Large Application with Multiple UI Maps](../vs140/testing-a-large-application-with-multiple-ui-maps.md)   
 [Supported Configurations and Platforms for Coded UI Tests and Action Recordings](../vs140/supported-configurations-and-platforms-for-coded-ui-tests-and-action-recordings.md)