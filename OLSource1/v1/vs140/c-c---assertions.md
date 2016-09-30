---
title: "C-C++ Assertions"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "C/C++ Assertions"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "debugging [MFC], assertions"
  - "results, checking"
  - "result checking"
  - "Call Stack window, assertion failures"
  - "debugging [C++], assertions"
  - "VERIFY macro"
  - "assertions, side effects"
  - "assertions"
  - "ASSERT macro"
  - "errors [C++], catching with assertions"
  - "testing, error conditions with assertion statements"
  - "_DEBUG macro"
  - "Assertion Failed dialog box"
  - "failures, finding locations"
ms.assetid: 2d7b0121-71aa-414b-bbb6-ede1093d0bfc
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# C-C++ Assertions
An assertion statement specifies a condition that you expect to be true at a point in your program. If that condition is not true, the assertion fails, execution of your program is interrupted, and the [Assertion Failed dialog box](../vs140/assertion-failed-dialog-box.md) appears.  
  
 Visual C++ supports assertion statements that are based on the following constructs:  
  
-   MFC assertions for MFC programs.  
  
-   [ATLASSERT](../vs140/atlassert.md) for programs that use ATL.  
  
-   CRT assertions for programs that use the C run-time library.  
  
-   The ANSI [assert function](../vs140/assert-macro--_assert--_wassert.md) for other C/C++ programs.  
  
 You can use assertions to catch logic errors, check results of an operation, and Test error conditions that should have been handled.  
  
##  \<a name="BKMK_In_this_topic">\</a> In this topic  
 [How assertions work](#BKMK_How_assertions_work)  
  
 [Assertions in Debug and Release builds](#BKMK_Assertions_in_Debug_and_Release_builds)  
  
 [Side effects of using assertions](#BKMK_Side_effects_of_using_assertions)  
  
 [CRT assertions](#BKMK_CRT_assertions)  
  
 [MFC assertions](#BKMK_MFC_assertions)  
  
-   [MFC ASSERT_VALID and CObject::AssertValid](#BKMK_MFC_ASSERT_VALID_and_CObject__AssertValid)  
  
-   [Limitations of AssertValid](#BKMK_Limitations_of_AssertValid)  
  
 [Using assertions](#BKMK_Using_assertions)  
  
-   [Catching logic errors](#BKMK_Catching_logic_errors)  
  
-   [Checking results](#BKMK_Checking_results_)  
  
-   [Testing error conditions](#BKMK_Testing_error_conditions_)  
  
##  \<a name="BKMK_How_assertions_work">\</a> How assertions work  
 When the debugger halts because of an MFC or C run-time library assertion, then if the source is available, the debugger navigates to the point in the source file where the assertion occurred. The assertion message appears in both the [Output window](../vs140/output-window.md) and the **Assertion Failed** dialog box. You can copy the assertion message from the **Output** window to a text window if you want to save it for future reference. The **Output** window may contain other error messages as well. Examine these messages carefully, because they provide clues to the cause of the assertion failure.  
  
 Use assertions to detect errors during development. As a rule, use one assertion for each assumption. For example, if you assume that an argument is not NULL, use an assertion to test that assumption.  
  
 [In this topic](#BKMK_In_this_topic)  
  
##  \<a name="BKMK_Assertions_in_Debug_and_Release_builds">\</a> Assertions in Debug and Release builds  
 Assertion statements compile only if <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is defined. Otherwise, the compiler treats assertions as null statements. Therefore, assertion statements impose no overhead or performance cost in your final Release program, and allow you to avoid using <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> directives.  
  
##  \<a name="BKMK_Side_effects_of_using_assertions">\</a> Side effects of using assertions  
 When you add assertions to your code, make sure the assertions do not have side effects. For example, consider the following assertion that modifies the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> value:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Because the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> expression is not evaluated in the Release version of your program, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> will have different values in the Debug and Release versions. To avoid this problem in MFC, you can use the [VERIFY](../vs140/verify.md) macro instead of <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> evaluates the expression in all versions but does not check the result in the Release version.  
  
 Be especially careful about using function calls in assertion statements, because evaluating a function can have unexpected side effects.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> calls <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> in both the Debug and Release versions, so it is acceptable to use. However, using <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> imposes the overhead of an unnecessary function call in the Release version.  
  
 [In this topic](#BKMK_In_this_topic)  
  
##  \<a name="BKMK_CRT_assertions">\</a> CRT assertions  
 The CRTDBG.H header file defines the [_ASSERT and _ASSERTE macros](../vs140/_assert--_asserte--_assert_expr-macros.md) for assertion checking.  
  
|Macro|Result|  
|-----------|------------|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|If the specified expression evaluates to FALSE, the file name and line number of the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|Same as <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, plus a string representation of the expression that was asserted.|  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is more powerful because it reports the asserted expression that turned out to be FALSE. This may be enough to identify the problem without referring to the source code. However, the Debug version of your application will contain a string constant for each expression asserted using <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>. If you use many <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> macros, these string expressions take up a significant amount of memory. If that proves to be a problem, use <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> to save memory.  
  
 When <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is defined, the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> macro is defined as follows:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 If the asserted expression evaluates to FALSE, [_CrtDbgReport](../vs140/_crtdbgreport--_crtdbgreportw.md) is called to report the assertion failure (using a message dialog box by default). If you choose **Retry** in the message dialog box, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> returns 1 and <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> calls the debugger through <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.  
  
### Checking for Heap Corruption  
 The following example uses [_CrtCheckMemory](../vs140/_crtcheckmemory.md) to check for corruption of the heap:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Checking Pointer Validity  
 The following example uses [_CrtIsValidPointer](../vs140/_crtisvalidpointer.md) to verify that a given memory range is valid for reading or writing.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The following example uses [_CrtIsValidHeapPointer](../vs140/_crtisvalidheappointer.md) to verify a pointer points to memory in the local heap (the heap created and managed by this instance of the C run-time library — a DLL can have its own instance of the library, and therefore its own heap, outside of the application heap). This assertion catches not only null or out-of-bounds addresses, but also pointers to static variables, stack variables, and any other nonlocal memory.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Checking a Memory Block  
 The following example uses [_CrtIsMemoryBlock](../vs140/_crtismemoryblock.md) to verify that a memory block is in the local heap and has a valid block type.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [In this topic](#BKMK_In_this_topic)  
  
##  \<a name="BKMK_MFC_assertions">\</a> MFC assertions  
 MFC defines the [ASSERT](../vs140/assert--mfc-.md) macro for assertion checking. It also defines the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> methods for checking the internal state of a <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>-derived object.  
  
 If the argument of the MFC <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> macro evaluates to zero or false, the macro halts program execution and alerts the user; otherwise, execution continues.  
  
 When an assertion fails, a message dialog box shows the name of the source file and the line number of the assertion. If you choose Retry in the dialog box, a call to [AfxDebugBreak](../vs140/afxdebugbreak--mfc-.md) causes execution to break to the debugger. At that point, you can examine the call stack and use other debugger facilities to determine why the assertion failed. If you have enabled [Just-in-time debugging](../vs140/just-in-time-debugging-in-visual-studio.md), and the debugger was not already running, the dialog box can launch the debugger.  
  
 The following example shows how to use <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> to check the return value of a function:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 You can use ASSERT with the [IsKindOf](../vs140/cobject--iskindof.md) function to provide type checking of function arguments:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> macro produces no code in the Release version. If you need to evaluate the expression in the Release version, use the [VERIFY](../vs140/verify.md) macro instead of ASSERT.  
  
###  \<a name="BKMK_MFC_ASSERT_VALID_and_CObject__AssertValid">\</a> MFC ASSERT_VALID and CObject::AssertValid  
 The [CObject::AssertValid](../vs140/cobject--assertvalid.md) method provides run-time checks of the internal state of an object. Although you are not required to override <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> when you derive your class from <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, you can make your class more reliable by doing this. <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> should perform assertions on all of the object's member variables to verify that they contain valid values. For example, it should check that pointer member variables are not NULL.  
  
 The following example shows how to declare an <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> function:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 When you override <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>, call the base class version of <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> before you perform your own checks. Then use the ASSERT macro to check the members unique to your derived class, as shown here:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 If any of your member variables store objects, you can use the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> macro to test their internal validity (if their classes override <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>).  
  
 For example, consider a class <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>, which stores a [CObList](../vs140/coblist-class.md) in one of its member variables. The <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> variable, <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>, stores a collection of <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> objects. An abbreviated declaration of <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> looks like this:  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> override in <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> looks like this:  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> uses the <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> mechanism to test the validity of the objects stored in its data member. The overriding <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> of <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> invokes the <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> macro for its own m_pDataList member variable.  
  
 Validity testing does not stop at this level because the class <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> also overrides <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>. This override performs additional validity testing on the internal state of the list. Thus, a validity test on a <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> object leads to additional validity tests for the internal states of the stored <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> list object.  
  
 With some more work, you could add validity tests for the <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> objects stored in the list also. You could derive a class <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> from <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> and override <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>. In the override, you would call <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> and then iterate through the list, calling <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> on each <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> object stored in the list. The <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> class shown at the beginning of this topic already overrides <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>.  
  
 This is a powerful mechanism when you build for debugging. When you subsequently build for release, the mechanism is turned off automatically.  
  
###  \<a name="BKMK_Limitations_of_AssertValid">\</a> Limitations of AssertValid  
 A triggered assertion indicates that the object is definitely bad and execution will stop. However, a lack of assertion indicates only that no problem was found, but the object is not guaranteed to be good.  
  
 [In this topic](#BKMK_In_this_topic)  
  
##  \<a name="BKMK_Using_assertions">\</a> Using assertions  
  
###  \<a name="BKMK_Catching_logic_errors">\</a> Catching logic errors  
 You can set an assertion on a condition that must be true according to the logic of your program. The assertion has no effect unless a logic error occurs.  
  
 For example, suppose you are simulating gas molecules in a container, and the variable <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> represents the total number of molecules. This number cannot be less than zero, so you might include an MFC assertion statement like this:  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Or you might include a CRT assertion like this:  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 These statements do nothing if your program is operating correctly. If a logic error causes <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> to be less than zero, however, the assertion halts the execution of your program and displays the [Assertion Failed Dialog Box](../vs140/assertion-failed-dialog-box.md).  
  
 [In this topic](#BKMK_In_this_topic)  
  
###  \<a name="BKMK_Checking_results_">\</a> Checking results  
 Assertions are valuable for testing operations whose results are not obvious from a quick visual inspection.  
  
 For example, consider the following code, which updates the variable <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> based on the contents of the linked list pointed to by <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 The number of molecules counted by <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> must always be less than or equal to the total number of molecules, <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>. Visual inspection of the loop does not show that this will necessarily be the case, so an assertion statement is used after the loop to test for that condition.  
  
 [In this topic](#BKMK_In_this_topic)  
  
###  \<a name="BKMK_Testing_error_conditions_">\</a> Finding unhandled errors  
 You can use assertions to test for error conditions at a point in your code where any errors should have been handled. In the following example, a graphic routine returns an error code or zero for success.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 If the error-handling code works properly, the error should be handled and <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> reset to zero before the assertion is reached. If <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> has another value, the assertion fails, the program halts, and the [Assertion Failed Dialog Box](../vs140/assertion-failed-dialog-box.md) appears.  
  
 Assertion statements are not a substitute for error-handling code, however. The following example shows an assertion statement that can lead to problems in the final release code:  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 This code relies on the assertion statement to handle the error condition. As a result, any error code returned by <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> will be unhandled in the final release code.  
  
 [In this topic](#BKMK_In_this_topic)  
  
## See Also  
 [Debugger Security](../vs140/debugger-security.md)   
 [Debugging Native Code](../vs140/debugging-native-code.md)   
 [Assertions in Managed Code](../vs140/assertions-in-managed-code.md)