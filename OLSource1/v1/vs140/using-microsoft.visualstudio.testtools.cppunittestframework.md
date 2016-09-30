---
title: "Using Microsoft.VisualStudio.TestTools.CppUnitTestFramework"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: d1ac9188-d79f-407e-9f3a-80dbefa66317
caps.latest.revision: 12
ms.author: "mlearned"
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using Microsoft.VisualStudio.TestTools.CppUnitTestFramework
This topic lists the public members of the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> namespace.  
  
 The header files are located in the  *VisualStudio2012[x86]InstallFolder***\VC\UnitTest\include** folder.  
  
 The lib files are located in the  *VisualStudio2012[x86]InstallFolder***\VC\UnitTest\lib** folder.  
  
##  \<a name="BKMK_In_this_topic">\</a> In this topic  
 [CppUnitTest.h](#BKMK_CppUnitTest_h)  
  
-   [Create test classes and methods](#BKMK_Create_test_classes_and_methods)  
  
-   [Initialize and cleanup](#BKMK_Initialize_and_cleanup)  
  
    -   [Test methods](#BKMK_Test_methods)  
  
    -   [Test classes](#BKMK_Test_classes)  
  
    -   [Test modules](#BKMK_Test_modules)  
  
-   [Create test attributes](#BKMK_Create_test_attributes)  
  
    -   [Test method attributes](#BKMK_Test_method_attributes)  
  
    -   [Test class attributes](#BKMK_Test_class_attributes)  
  
    -   [Test module attributes](#BKMK_Test_module_attributes)  
  
    -   [Pre-defined attributes](#BKMK_Pre_defined_attributes)  
  
     [CppUnitTestAssert.h](#BKMK_CppUnitTestAssert_h)  
  
    -   [General Asserts](#BKMK_General_Asserts)  
  
        -   [Are Equal](#BKMK_General_Are_Equal)  
  
        -   [Are Not Equal](#BKMK_General_Are_Not_Equal)  
  
        -   [Are Same](#BKMK_General_Are_Same)  
  
        -   [Are Not Same](#BKMK_General_Are_Not_Same)  
  
        -   [Is Null](#BKMK_General_Is_Null)  
  
        -   [Is Not Null](#BKMK_General_Is_Not_Null)  
  
        -   [Is True](#BKMK_General_Is_True)  
  
        -   [Is False](#BKMK_General_Is_False)  
  
        -   [Fail](#BKMK_General_Fail)  
  
    -   [Windows Runtime Asserts](#BKMK_WinRT_Asserts)  
  
        -   [Are Equal](#BKMK_WinRT_Are_Equal)  
  
        -   [Are Same](#BKMK_WinRT_Are_Same)  
  
        -   [Are Not Equal](#BKMK_WinRT_Are_Not_Equal)  
  
        -   [Are Not Same](#BKMK_WinRT_Are_Not_Same)  
  
        -   [Is Null](#BKMK_WinRT_Is_Null)  
  
        -   [Is Not Null](#BKMK_WinRT_Is_Not_Null)  
  
    -   [Exception Asserts](#BKMK_Exception_Asserts)  
  
        -   [Expect Exception](#BKMK_Expect_Exception)  
  
         [CppUnitTestLogger.h](#BKMK_CppUnitTestLogger_h)  
  
        -   [Logger](#BKMK_Logger)  
  
        -   [Write Message](#BKMK_Write_Message)  
  
##  \<a name="BKMK_CppUnitTest_h">\</a> CppUnitTest.h  
  
###  \<a name="BKMK_Create_test_classes_and_methods">\</a> Create test classes and methods  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Required for each class containing test methods. Identifies *className* as a test class. <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> must be declared at namescape scope.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Defines *methodName* as a test method. <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> must be declared in the scope of the method's class.  
  
###  \<a name="BKMK_Initialize_and_cleanup">\</a> Initialize and cleanup  
  
####  \<a name="BKMK_Test_methods">\</a> Test methods  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Defines *methodName* as a method that runs before each test method is run. <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> can only be defined once in a test class and must be defined in the test class.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Defines *methodName* as a method that runs after each test method is run. <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> can only be defined once in a test class and must be defined in the scope of the test class.  
  
####  \<a name="BKMK_Test_classes">\</a> Test classes  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Defines *methodName* as a method that runs after each test class is created. <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> can only be defined once in a test class and must be defined in the scope of the test class.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Defines *methodName* as a method that runs after each test class is created. <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> can only be defined once in a test class and must be defined in the scope of the test class.  
  
####  \<a name="BKMK_Test_modules">\</a> Test modules  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Defines the method *methodName* that runs when a module is loaded. <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> can only be defined once in a test module and must be declared at namespace scope.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Defines the method *methodName* that runs when a module is unloaded. <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> can only be defined once in a test module and must be declared at namespace scope.  
  
###  \<a name="BKMK_Create_test_attributes">\</a> Create test attributes  
  
####  \<a name="BKMK_Test_method_attributes">\</a> Test method attributes  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Adds the attributes defined with one or more <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> macros to the test method *testClassName*.  
  
 A <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> macro defines an attribute with the name *attributeName* and the value *attributeValue*.  
  
####  \<a name="BKMK_Test_class_attributes">\</a> Test class attributes  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Adds the attributes defined with one or more <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> macros to the test class *testClassName*.  
  
 A <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> macro defines an attribute with the name *attributeName* and the value *attributeValue*.  
  
####  \<a name="BKMK_Test_module_attributes">\</a> Test module attributes  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Adds the attributes defined with one or more <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> macros to the test module *testModuleName*.  
  
 A <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> macro defines an attribute with the name *attributeName* and the value *attributeValue*.  
  
####  \<a name="BKMK_Pre_defined_attributes">\</a> Pre-defined attributes  
 These pre-defined attribute macros can be substituted for the macros <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, OR <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> described above.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Defines an attribute with the name <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> and the attribute value of *ownerAlias*.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Defines an attribute with the name <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> and the attribute value of *description*.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Defines an attribute with the name <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> and the attribute value of *priority*.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 Defines an attribute with the name <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> and the attribute value of *workItem*.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 Defines an attribute with the name <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> and the attribute value of <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>.  
  
##  \<a name="BKMK_CppUnitTestAssert_h">\</a> CppUnitTestAssert.h  
  
###  \<a name="BKMK_General_Asserts">\</a> General Asserts  
  
####  \<a name="BKMK_General_Are_Equal">\</a> Are Equal  
 Verify that two objects are equal  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 Verify that two doubles are equal  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 Verify that two floats are equal  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 Verify that two char* strings are equal  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 Verify that two w_char* strings are equal  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
####  \<a name="BKMK_General_Are_Not_Equal">\</a> Are Not Equal  
 Verify that two doubles are not equal  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 Verify that two floats are not equal  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 Verify that two char* strings are not equal  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 Verify that two w_char* strings are not equal  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 Verify that two references are not equal based on operator==.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
####  \<a name="BKMK_General_Are_Same">\</a> Are Same  
 Verify that two references refer to the same object instance (identity).  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
####  \<a name="BKMK_General_Are_Not_Same">\</a> Are Not Same  
 Verify that two references do not refer to the same object instance (identity).  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
####  \<a name="BKMK_General_Is_Null">\</a> Is Null  
 Verify that a pointer is NULL.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
####  \<a name="BKMK_General_Is_Not_Null">\</a> Is Not Null  
 Verify that a pointer is not NULL  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
####  \<a name="BKMK_General_Is_True">\</a> Is True  
 Verify that a condition is true  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
####  \<a name="BKMK_General_Is_False">\</a> Is False  
 Verify that a condition is false  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
####  \<a name="BKMK_General_Fail">\</a> Fail  
 Force the test case result to be failed  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
###  \<a name="BKMK_WinRT_Asserts">\</a> Windows Runtime Asserts  
  
####  \<a name="BKMK_WinRT_Are_Equal">\</a> Are Equal  
 Verifies that two Windows Runtime pointers are equal.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 Verifies that two Platform::String^ strings are equal.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
####  \<a name="BKMK_WinRT_Are_Same">\</a> Are Same  
 Verifies that two Windows Runtime references reference the same object.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
####  \<a name="BKMK_WinRT_Are_Not_Equal">\</a> Are Not Equal  
 Verifies that two Windows Runtime pointers are not equal.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 Verifies that two Platform::String^ strings are not equal.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
####  \<a name="BKMK_WinRT_Are_Not_Same">\</a> Are Not Same  
 Verifies that two Windows Runtime references do not reference the same object.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
####  \<a name="BKMK_WinRT_Is_Null">\</a> Is Null  
 Verifies that a Windows Runtime pointer is a nullptr.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
####  \<a name="BKMK_WinRT_Is_Not_Null">\</a> Is Not Null  
 Verifies that a Windows Runtime pointer is not a nullptr.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
###  \<a name="BKMK_Exception_Asserts">\</a> Exception Asserts  
  
####  \<a name="BKMK_Expect_Exception">\</a> Expect Exception  
 Verify that a function raises an exception:  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 Verify that a function raises an exception:  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
##  \<a name="BKMK_CppUnitTestLogger_h">\</a> CppUnitTestLogger.h  
  
###  \<a name="BKMK_Logger">\</a> Logger  
 The Logger class contains static methods to write to  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
###  \<a name="BKMK_Write_Message">\</a> Write Message  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
## Example  
 This code is an example of  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
## See Also  
 [Verifying Code by Using Unit Tests](../vs140/unit-test-your-code.md)   
 [Unit testing native code with Test Explorer](assetId:///8a09d6d8-3613-49d8-9ffe-11375ac4736c)   
 [Unit testing existing C++ applications with Test Explorer](../vs140/unit-testing-existing-c---applications-with-test-explorer.md)