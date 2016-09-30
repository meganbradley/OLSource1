---
title: "Run unit tests on UML extensions"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 745d74ae-e48c-4fd9-a755-4354b81b9f8a
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Run unit tests on UML extensions
To help keep your code stable through successive changes, we recommend that you write unit tests and perform them as part of a regular build process. For more information, see [Verifying Code by using Unit Tests](../vs140/unit-test-your-code.md). To set up tests for Visual Studio modeling extensions, you need some key pieces of information. In summary:  
  
-   [Setting up a Unit Test for VSIX Extensions](#Host)  
  
     Run tests with the VS IDE host adapter. Prefix each test method with <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. This host adapter starts [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] when your tests run.  
  
-   [Accessing DTE and ModelStore](#DTE)  
  
     Typically, you will have to open a model and its diagrams and access the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> in the test initialization.  
  
-   [Opening a Model Diagram](#Opening)  
  
     You can cast <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to and from <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
-   [Performing Changes in the UI Thread](#UiThread)  
  
     Tests that make changes to the model store must be performed in the UI thread. You can use <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> for this.  
  
-   [Testing commands, gestures and other MEF components](#MEF)  
  
     To test MEF components, you must explicitly connect their imported properties to values.  
  
 These points are elaborated in the following sections.  
  
 A sample of a unit tested UML extension can be found on Code Samples Gallery at [UML – Rapid Entry by using Text](http://code.msdn.microsoft.com/UML-Rapid-Entry-using-Text-0813ad8a).  
  
## Requirements  
 See [Extend UML models and diagrams](../vs140/extend-uml-models-and-diagrams.md#Requirements).  
  
 To see which versions of Visual Studio support this feature, see [Version support for architecture and modeling tools](../vs140/what-s-new-for-design-in-visual-studio.md#VersionSupport).  
  
##  \<a name="Host">\</a> Setting up a Unit Test for VSIX Extensions  
 The methods in your modeling extensions usually work with a diagram that is already open. The methods use MEF imports such as **IDiagramContext** and **ILinkedUndoContext**. Your test environment must set up this context before you run the tests.  
  
#### To set up a unit test that executes in [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)]  
  
1.  Create the UML extension project and the unit test project.  
  
    1.  **A UML extension project.** Typically you create this by using the command, gesture, or validation project templates. For example, see [How to create a modeling command](../vs140/define-a-menu-command-on-a-modeling-diagram.md).  
  
    2.  **A unit test project.** For more information, see [Verifying code by using unit tests](../vs140/unit-test-your-code.md).  
  
2.  Create a [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] solution that contains a UML modeling project. You will use this solution as the initial state of your tests. It should be separate from the solution in which you write the UML extension and its unit tests. For more information, see [How to create modeling projects](../vs140/create-uml-modeling-projects-and-diagrams.md).  
  
3.  **In the UML extension project**, edit the .csproj file as text and make sure that the following lines show <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     To edit the .csproj file as text, choose **Unload Project** on the shortcut menu of the project in Solution Explorer. Then choose **Edit ….csproj**. After you have edited the text, choose **Reload Project**.  
  
4.  In your UML extension project, add the following line to **Properties\AssemblyInfo.cs**. This allows the unit tests to access the methods that you want to test:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
5.  **In the unit test project**, add the following assembly References:  
  
    -   *Your UML extension project*  
  
    -   **EnvDTE.dll**  
  
    -   **Microsoft.VisualStudio.ArchitectureTools.Extensibility.dll**  
  
    -   **Microsoft.VisualStudio.ComponentModelHost.dll**  
  
    -   **Microsoft.VisualStudio.QualityTools.UnitTestFramework.dll**  
  
    -   **Microsoft.VisualStudio.Uml.Interfaces.dll**  
  
    -   **Microsoft.VSSDK.TestHostFramework.dll**  
  
6.  Prefix the attribute <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> to each test method, including initialization methods.  
  
     This will ensure that the test will run in an experimental instance of Visual Studio.  
  
##  \<a name="DTE">\</a> Accessing DTE and ModelStore  
 Write a method to open a modeling project in [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)]. Typically, you want to open a solution only once in each test run. To run the method only once, prefix the method with the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> attribute. Don’t forget that you also need the [HostType("VS IDE")] attribute on each test method.  For example:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Notice the following points:  
  
-   \<xref:Microsoft.VSSDK.Tools.VsIdeTesting.VsIdeTestHostContext*?displayProperty=fullName> provides access to the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] API \<xref:EnvDTE.DTE*?displayProperty=fullName>, and also to the DTE service provider.  
  
-   If an instance of \<xref:EnvDTE.Project*?displayProperty=fullName> represents a modeling project, then you can cast it to and from \<xref:Microsoft.VisualStudio.ArchitectureTools.Extensibility.IModelingProject*>.  
  
##  \<a name="Opening">\</a> Opening a Model Diagram  
 For each test or class of tests, you typically want to work with an open diagram. The following example uses the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> attribute, which executes this method before other methods in this test class. Again, don’t forget that you also need the attribute [HostType("VS IDE")] on each test method:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="UiThread">\</a> Perform Model Changes in the UI Thread  
 If your tests, or the methods under test, make changes to the model store, then you must execute them in the user interface thread. If you do not do this, you might see an <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. Enclose the code of the test method in a call to Invoke:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="MEF">\</a> Testing command, gesture and other MEF components  
 MEF components use property declarations that have the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> attribute, and whose values are set by their hosts. Typically, such properties include IDiagramContext, SVsServiceProvider, and ILinkedUndoContext. When you test a method that uses any of these properties, you have to set their values before executing the method under test. For example, if you have written a command extension resembling this code:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Then you can set the imported properties as follows:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 If you want to test a method that takes an imported property as a parameter, then you can import the property into your test class, and apply <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> to the test instance. For example:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 In this example, the two attributes on each test method are combined for convenience into one line.  
  
## Access from tests to private methods and variables  
 Sometimes you want to test a method that is private, or you want to verify the state of a field that is private, before and after you execute a method under test. This presents a difficulty because the tests are in a separate assembly to the classes under test. There are several tactics that you can consider, including the following:  
  
 Test only by using public and internal items  
 Write your tests so that they use only public (or internal) classes and members. This is the best approach. Your tests will continue to work even if you refactor the internal implementation of the assembly under test. By applying the same tests before and after the changes, you can be sure that your changes have not altered the behavior of the assembly.  
  
 To make this possible, you might have to restructure your code. For example, you might need to separate some methods into another class.  
  
 By giving serious consideration to this approach, you will often find that your code is made easier to read and change, and less prone to errors when changes are necessary.  
  
 You can allow the test assembly to access internal items by adding an attribute in **Properties\AssemblyInfo.cs** in the project to be tested:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Define a test interface  
 Define an interface that includes both the public members of a class to be tested, and additional properties and methods for the private members that you want the tests to be able to use. Add this interface to the project to be tested. For example:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Add methods to the class to be tested, to implement the accessor methods explicitly. Keep these additional methods separate from the main class by writing them in a partial class definition in a separate file. For example:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Allow the test assembly to use the test interfaces by adding this attribute to the assembly that you are testing:  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 In the unit test methods, use the test interface. For example:  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Define accessors by using reflection  
 This is the way that we recommend least. Older versions of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] provided a utility that automatically created an accessor method for each private method. Although this is convenient, our experience suggests that it tends to result in unit tests that are very strongly coupled to the internal structure of the application that they are testing. This results in extra work when the requirements or architecture change, because the tests have to be changed along with the implementation. Also, any erroneous assumptions in the design of the implementation are also built into the tests, so that the tests do not find errors.  
  
## See Also  
 [Anatomy of a Unit Test](assetId:///a03d1ee7-9999-4e7c-85df-7d9073976144)   
 [How to define a command on a modeling diagram](../vs140/define-a-menu-command-on-a-modeling-diagram.md)   
 [UML – Rapid Entry by using Text](http://code.msdn.microsoft.com/UML-Rapid-Entry-using-Text-0813ad8a)