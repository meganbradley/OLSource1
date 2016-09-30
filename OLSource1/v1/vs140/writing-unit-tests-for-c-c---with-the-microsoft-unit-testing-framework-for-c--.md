---
title: "Writing Unit tests for C-C++ with the Microsoft Unit Testing Framework for C++"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "Writing Unit tests for C/C++ with the Microsoft Unit Testing Framework for C++"
ms.assetid: 4f4b5f10-7314-4725-8c6e-e72f52eff918
caps.latest.revision: 18
ms.author: "mlearned"
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Writing Unit tests for C-C++ with the Microsoft Unit Testing Framework for C++
In Visual Studio, you can create unit tests for unmanaged code written in C++. Unmanaged code is sometimes referred to as native code.  
  
 The following procedure contains the essential information that will get you started. The later sections provide a walkthrough that describes the steps in more detail.  
  
### To write unit tests for an unmanaged code DLL  
  
1.  Use the **Native Test Project** template to create a separate Visual Studio project for your tests.  
  
     The project contains some sample test code.  
  
2.  Make the DLL accessible to the test project:  
  
    -   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> file that contains declarations of the DLL’s externally-accessible functions.  
  
         The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> file should contain function declarations marked with <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. Alternatively, you can export the methods using a DEF file. For more information, see [Importing and Exporting from a DLL](../vs140/importing-and-exporting.md).  
  
         Your unit tests can access only functions that are exported from the DLL under test.  
  
    -   Add the DLL project to the References of the test project:  
  
         In the **Properties** of the test project, expand **Common Properties**, **Framework and References**, and choose **Add Reference**.  
  
3.  In the test project, create test classes and test methods by using the TEST macros and Assert class in the following way:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
    -   <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> contains several static functions that you can use to verify the result of a test.  
  
    -   The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> parameter is optional. In cases where there is no PDB file, it allows the test runner to identify the location of a failure.  
  
    -   You can also write test setup and cleanup methods. For more information, open the definition of the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> macro, and read the comments in CppUnitTest.h  
  
    -   You cannot nest test classes.  
  
4.  Use Test Explorer to run the tests:  
  
    1.  On the **View** menu, choose **Other Windows**, **Test Explorer**.  
  
    2.  Build the Visual Studio solution.  
  
    3.  In Test Explorer, choose **Run All**.  
  
    4.  To investigate any test in more detail in Test Explorer:  
  
        1.  Select the test name to see more details such as a failure message and stack trace.  
  
        2.  Open the test name (for example by double-clicking) to go to the failure location or to the test code.  
  
        3.  On the shortcut menu for a test, choose **Debug Selected Test** to run the test in the debugger.  
  
##  \<a name="walkthrough">\</a> Walkthrough: Developing an unmanaged DLL with Test Explorer  
 You can adapt this walkthrough to develop your own DLL. The principal steps are as follows:  
  
1.  [Create a Native Test Project](#unitTestProject). The tests are created in a separate project from the DLL that you are developing.  
  
2.  [Create a DLL Project](#createDllProject). This walkthrough creates a new DLL, but the procedure for testing an existing DLL is similar.  
  
3.  [Make the DLL functions visible to the tests](#coupleProjects).  
  
4.  [Iteratively augment the tests](#iterate). We recommend a "red-green-refactor" cycle, in which development of the code is led by the tests.  
  
5.  [Debug failing tests](#debug). You can run tests in debug mode.  
  
6.  [Refactor while keeping the tests unchanged](#refactor). Refactoring means improving the structure of the code without changing its external behavior. You can do it to improve the performance, extensibility, or readability of the code. Because the intention is not to change the behavior, you do not change the tests while making a refactoring change to the code. The tests help make sure  that you do not introduce bugs while you are refactoring. You can therefore make such changes with much more confidence than if you did not have the tests.  
  
7.  [Check coverage](https://msdn.microsoft.com/en-us/library/fc8hec9e.aspx). Unit tests are more useful when they exercise more of your code. You can discover which parts of your code have been used by the tests.  
  
8.  [Isolate units from external resources](https://msdn.microsoft.com/library/hh549174.aspx). Typically, a DLL is dependent on other components of the system that you are developing, such as other DLLs, databases, or remote subsystems. It is useful to test each unit in isolation from its dependencies. External components can make tests run slowly. During development, the other components might not be complete.  
  
###  \<a name="unitTestProject">\</a> Create a native unit test project  
  
1.  On the **File** menu, choose **New**, **Project**.  
  
     In the dialog box, expand **Installed**, **Templates**, **Visual C++**, **Test**.  
  
     Choose the **Native Test Project** template.  
  
     In this walkthrough, the test project is named <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
     ![Creating a C&#43;&#43; Unit Test Project](../vs140/media/utecpp01.png "UteCpp01")  
  
2.  In the new project, inspect **unittest1.cpp**  
  
     ![Test project with TEST&#95;CLASS and TEST&#95;METHOD](../vs140/media/utecpp2.png "UteCpp2")  
  
     Notice that:  
  
    -   Each test is defined by using <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
         You do not have to write a conventional function signature. The signature is created by the macro TEST_METHOD. The macro generates an instance function that returns void. It also generates a static function that returns information about the test method. This information allows the test explorer to find the method.  
  
    -   Test methods are grouped into classes by using <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
         When the tests are run, an instance of each test class is created. The test methods are called in an unspecified order. You can define special methods that are invoked before and after each module, class, or method.  
  
3.  Verify that the tests run in Test Explorer:  
  
    1.  Insert some test code:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
         Notice that the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> class provides several static methods that you can use to verify results in test methods.  
  
    2.  On the **Test** menu, choose **Run** , **All Tests**.  
  
         The test builds and runs.  
  
         Test Explorer appears.  
  
         The test appears under **Passed Tests**.  
  
         ![Unit Test Explorer with one passed test](../vs140/media/utecpp04.png "UteCpp04")  
  
###  \<a name="createDllProject">\</a> Create an Unmanaged DLL project  
  
1.  Create a **Visual C++** project by using the **Win32 Project** template.  
  
     In this walkthrough, the project is named <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
     ![Creating a C&#43;&#43; Win32 project](../vs140/media/utecpp05.png "UteCpp05")  
  
2.  Select **DLL** and **Export Symbols** in the Win32 Application Wizard.  
  
     The **Export Symbols** option generates a convenient macro that you can use to declare exported methods.  
  
     ![C&#43;&#43; project wizard set for DLL and Export Symbols](../vs140/media/utecpp06.png "UteCpp06")  
  
3.  Declare an exported function in the principal .h file:  
  
     ![New DLL code project and .h file with API macros](../vs140/media/utecpp07.png "UteCpp07")  
  
     The declarator <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> causes the public and protected members of the class to be visible outside the DLL. For more information, see [Using dllimport and dllexport in C++ classes](../vs140/using-dllimport-and-dllexport-in-c---classes.md).  
  
4.  In the principal .cpp file, add a minimal body for the function:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
###  \<a name="coupleProjects">\</a> Couple the test project to the DLL project  
  
1.  Add the DLL project to the project references of the test project:  
  
    1.  Open the properties of the test project and choose **Common Properties**, **Framework and References**.  
  
         ![C&#43;&#43; project properties &#45; Framework and References](../vs140/media/utecpp08.png "UteCpp08")  
  
    2.  Choose **Add New Reference**.  
  
         In the **Add Reference** dialog box, select the DLL project and choose **Add**.  
  
         ![C&#43;&#43; project properties &#45; Add New Reference](../vs140/media/utecpp09.png "UteCpp09")  
  
2.  In the principal unit test .cpp file, include the .h file of the DLL code:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
3.  Add a basic test that uses the exported function:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
4.  Build the solution.  
  
     The new test appears in Test Explorer.  
  
5.  In Test Explorer, choose **Run All**.  
  
     ![Unit Test Explorer &#45; Basic Test passed](../vs140/media/utecpp10.png "UteCpp10")  
  
 You have set up the test and the code projects, and verified that you can run tests that run functions in the code project. Now you can begin to write real tests and code.  
  
###  \<a name="iterate">\</a> Iteratively augment the tests and make them pass  
  
1.  Add a new test:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
    > [!TIP]
    >  We recommend that you do not change tests that have passed. Instead, add a new test, update the code so that the test passes, and then add another test, and so on.  
    >   
    >  When your users change their requirements, disable the tests that are no longer correct. Write new tests and make them work one at a time, in the same incremental manner.  
  
2.  Build the solution, and then in Test Explorer, choose **Run All**.  
  
     The new test fails.  
  
     ![The RangeTest fails](../vs140/media/ute_cpp_testexplorer_rangetest_fail.png "UTE_Cpp_TestExplorer_RangeTest_Fail")  
  
    > [!TIP]
    >  Verify that each test fails immediately after you have written it. This helps you avoid the easy mistake of writing a test that never fails.  
  
3.  Enhance the code under test so that the new test passes:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
4.  Build the solution and then in Test Explorer, choose **Run All**.  
  
     Both tests pass.  
  
     ![Unit Test Explorer &#45; Range Test passed](../vs140/media/utecpp12.png "UteCpp12")  
  
    > [!TIP]
    >  Develop code by adding tests one at a time. Make sure that all the tests pass after each iteration.  
  
###  \<a name="debug">\</a> Debug a failing test  
  
1.  Add another test:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
2.  Build the solution and choose **Run All**.  
  
3.  Open (or double-click) the failed test.  
  
     The failed assertion is highlighted. The failure message is visible in the detail pane of Test Explorer.  
  
     ![NegativeRangeTests failed](../vs140/media/ute_cpp_testexplorer_negativerangetest_fail.png "UTE_Cpp_TestExplorer_NegativeRangeTest_Fail")  
  
4.  To see why the test fails, step through the function:  
  
    1.  Set a breakpoint at the start of the SquareRoot function.  
  
    2.  On the shortcut menu of the failed test, choose **Debug Selected Tests**.  
  
         When the run stops at the breakpoint, step through the code.  
  
5.  Insert code in the function that you are developing:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
6.  All tests now pass.  
  
     ![All tests pass](../vs140/media/ute_ult_alltestspass.png "UTE_ULT_AllTestsPass")  
  
> [!TIP]
>  If individual tests have no dependencies that prevent them from being run in any order, turn on parallel test execution with the ![UTE&#95;parallelicon&#45;small](../vs140/media/ute_parallelicon-small.png "UTE_parallelicon-small") toggle button on the toolbar. This can noticeably reduce the time taken to run all the tests.  
  
###  \<a name="refactor">\</a> Refactor the code without changing tests  
  
1.  Simplify the central calculation in the SquareRoot function:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
2.  Build the solution and choose **Run All**, to make sure that you have not introduced an error.  
  
    > [!TIP]
    >  A good set of unit tests gives confidence that you have not introduced bugs when you change the code.  
    >   
    >  Keep refactoring separate from other changes.  
  
## Next steps  
  
-   **Isolation.** Most DLLs are dependent on other subsystems such as databases and other DLLs. These other components are often developed in parallel. To allow unit testing to be performed while the other components are not yet available, you have to substitute mock or  
  
-   **Build Verification Tests.** You can have tests performed on your team’s build server at set intervals. This ensures that bugs are not introduced when the work of several team members is integrated.  
  
-   **Checkin tests.** You can mandate that some tests are performed before each team member checks code into source control. Typically this is a subset of the complete set of build verification tests.  
  
     You can also mandate a minimum level of code coverage.  
  
## See Also  
 [Unit testing existing C++ applications with Test Explorer](../vs140/unit-testing-existing-c---applications-with-test-explorer.md)   
 [Using Microsoft.VisualStudio.TestTools.CppUnitTestFramework](../vs140/using-microsoft.visualstudio.testtools.cppunittestframework.md)   
 [An Overview of Managed/Unmanaged Code Interoperability](http://msdn.microsoft.com/library/ms973872.aspx)   
 [Debugging Native Code](../vs140/debugging-native-code.md)   
 [Creating and Using a Dynamic Link Library](../vs140/walkthrough--creating-and-using-a-dynamic-link-library--c---.md)   
 [Importing and Exporting from a DLL](../vs140/importing-and-exporting.md)