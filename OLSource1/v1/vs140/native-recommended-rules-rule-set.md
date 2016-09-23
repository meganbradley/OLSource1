---
title: "Native Recommended Rules rule set"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 8d845b5a-1b75-4e9d-861a-7c59cb7752af
caps.latest.revision: 7
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Native Recommended Rules rule set
The Native Recommended Rules focus on the most critical and common problems in your native code, including potential security holes and application crashes.  You should include this rule set in any custom rule set you create for your native projects.  This ruleset is designed to work with Visual Studio Professional edition and higher.  
  
|Rule|Description|  
|----------|-----------------|  
|[C6001](../vs140/c6001.md)|Using Uninitialized Memory|  
|[C6011](../vs140/c6011.md)|Dereferencing Null Pointer|  
|[C6029](../vs140/c6029.md)|Use Of Unchecked Value|  
|[C6031](../vs140/c6031.md)|Return Value Ignored|  
|[C6053](../vs140/c6053.md)|Zero Termination From Call|  
|[C6054](../vs140/c6054.md)|Zero Termination Missing|  
|[C6059](../vs140/c6059.md)|Bad Concatenation|  
|[C6063](../vs140/c6063.md)|Missing String Argument To Format Function|  
|[C6064](../vs140/c6064.md)|Missing Integer Argument To Format Function|  
|[C6066](../vs140/c6066.md)|Missing Pointer Argument To Format Function|  
|[C6067](../vs140/c6067.md)|Missing String Pointer Argument To Format Function|  
|[C6101](../vs140/c6101.md)|Returning uninitialized memory|  
|[C6200](../vs140/c6200.md)|Index Exceeds Buffer Maximum|  
|[C6201](../vs140/c6201.md)|Index Exceeds Stack Buffer Maximum|  
|[C6214](../vs140/c6214.md)|Invalid Cast HRESULT To BOOL|  
|[C6215](../vs140/c6215.md)|Invalid Cast BOOL To HRESULT|  
|[C6216](../vs140/c6216.md)|Invalid Compiler-Inserted Cast BOOL To HRESULT|  
|[C6217](../vs140/c6217.md)|Invalid HRESULT Test With NOT|  
|[C6220](../vs140/c6220.md)|Invalid HRESULT Compare To -1|  
|[C6226](../vs140/c6226.md)|Invalid HRESULT Assignment To -1|  
|[C6230](../vs140/c6230.md)|Invalid HRESULT Use As Boolean|  
|[C6235](../vs140/c6235.md)|Non-Zero Constant With Logical-Or|  
|[C6236](../vs140/c6236.md)|Logical-Or With Non-Zero Constant|  
|[C6237](../vs140/c6237.md)|Zero With Logical-And Loses Side Effects|  
|[C6242](../vs140/c6242.md)|Local Unwind Forced|  
|[C6248](../vs140/c6248.md)|Creating Null DACL|  
|[C6250](../vs140/c6250.md)|Unreleased Address Descriptors|  
|[C6255](../vs140/c6255.md)|Unprotected Use Of Alloca|  
|[C6258](../vs140/c6258.md)|Using Terminate Thread|  
|[C6259](../vs140/c6259.md)|Dead Code In Bitwise-Or Limited Switch|  
|[C6260](../vs140/c6260.md)|Use Of Byte Arithmetic|  
|[C6262](../vs140/c6262.md)|Excessive Stack Usage|  
|[C6263](../vs140/c6263.md)|Using Alloca In Loop|  
|[C6268](../vs140/c6268.md)|Missing Parentheses In Cast|  
|[C6269](../vs140/c6269.md)|Pointer Dereference Ignored|  
|[C6270](../vs140/c6270.md)|Missing Float Argument To Format Function|  
|[C6271](../vs140/c6271.md)|Extra Argument To Format Function|  
|[C6272](../vs140/c6272.md)|Non-Float Argument To Format Function|  
|[C6273](../vs140/c6273.md)|Non-Integer Argumen To Format Function|  
|[C6274](../vs140/c6274.md)|Non-Character Argument To Format Function|  
|[C6276](../vs140/c6276.md)|Invalid String Cast|  
|[C6277](../vs140/c6277.md)|Invalid CreateProcess Call|  
|[C6278](../vs140/c6278.md)|Array-New Scalar-Delete Mismatch|  
|[C6279](../vs140/c6279.md)|Scalar-New Array-Delete Mismatch|  
|[C6280](../vs140/c6280.md)|Memory Allocation-Deallocation Mismatch|  
|[C6281](../vs140/c6281.md)|Bitwise Relation Precedence|  
|[C6282](../vs140/c6282.md)|Assignment Replaces Test|  
|[C6283](../vs140/c6283.md)|Primitive Array-New Scalar-Delete Mismatch|  
|[C6284](../vs140/c6284.md)|Invalid Object Argument To Format Function|  
|[C6285](../vs140/c6285.md)|Logical-Or Of Constants|  
|[C6286](../vs140/c6286.md)|Non-Zero Logical-Or Losing Side Effects|  
|[C6287](../vs140/c6287.md)|Redundant Test|  
|[C6288](../vs140/c6288.md)|Mutual Inclusion Over Logical-And Is False|  
|[C6289](../vs140/c6289.md)|Mutual Exclusion Over Logical-Or Is True|  
|[C6290](../vs140/c6290.md)|Logical-Not Bitwise-And Precedence|  
|[C6291](../vs140/c6291.md)|Logical-Not Bitwise-Or Precedence|  
|[C6292](../vs140/c6292.md)|Loop Counts Up From Maximum|  
|[C6293](../vs140/c6293.md)|Loop Counts Down From Minimum|  
|[C6294](../vs140/c6294.md)|Loop Body Never Executed|  
|[C6295](../vs140/c6295.md)|Infinite Loop|  
|[C6296](../vs140/c6296.md)|Loop Only Executed Once|  
|[C6297](../vs140/c6297.md)|Result Of Shift Cast To Larger Size|  
|[C6299](../vs140/c6299.md)|Bitfield To Boolean Comparison|  
|[C6302](../vs140/c6302.md)|Invalid Character String Argument To Format Function|  
|[C6303](../vs140/c6303.md)|Invalid Wide Character String Argument To Format Function|  
|[C6305](../vs140/c6305.md)|Mismatched Size And Count Use|  
|[C6306](../vs140/c6306.md)|Incorrect Variable Argument Function Call|  
|[C6308](../vs140/c6308.md)|Realloc Leak|  
|[C6310](../vs140/c6310.md)|Illegal Exception Filter Constant|  
|[C6312](../vs140/c6312.md)|Exception Continue Execution Loop|  
|[C6314](../vs140/c6314.md)|Bitwise-Or Precedence|  
|[C6317](../vs140/c6317.md)|Not Not Complement|  
|[C6318](../vs140/c6318.md)|Exception Continue Search|  
|[C6319](../vs140/c6319.md)|Ignored By Comma|  
|[C6324](../vs140/c6324.md)|String Copy Instead Of String Compare|  
|[C6328](../vs140/c6328.md)|Potential Argument Type Mismatch|  
|[C6331](../vs140/c6331.md)|VirtualFree Invalid Flags|  
|[C6332](../vs140/c6332.md)|VirtualFree Invalid Parameter|  
|[C6333](../vs140/c6333.md)|VirtualFree Invalid Size|  
|[C6335](../vs140/c6335.md)|Leaking Process Handle|  
|[C6381](../vs140/c6381.md)|Shutdown Information Missing|  
|[C6383](../vs140/c6383.md)|Element-Count Byte-Count Buffer Overrun|  
|[C6384](../vs140/c6384.md)|Pointer Size Division|  
|[C6385](../vs140/c6385.md)|Read Overrun|  
|[C6386](../vs140/c6386.md)|Write Overrun|  
|[C6387](../vs140/c6387.md)|Invalid Parameter Value|  
|[C6388](../vs140/c6388.md)|Invalid Parameter Value|  
|[C6500](../vs140/c6500.md)|Invalid Attribute Property|  
|[C6501](../vs140/c6501.md)|Conflicting Attribute Property Values|  
|[C6503](../vs140/c6503.md)|References Cannot Be Null|  
|[C6504](../vs140/c6504.md)|Null On Non-Pointer|  
|[C6505](../vs140/c6505.md)|MustCheck On Void|  
|[C6506](../vs140/c6506.md)|Buffer Size On Non-Pointer Or Array|  
|[C6507](assetId:///18f88cd1-d035-4403-a6a4-12dd0affcf21)|Null Mismatch At Dereference Zero|  
|[C6508](../vs140/c6508.md)|Write Access On Constant|  
|[C6509](../vs140/c6509.md)|Return Used On Precondition|  
|[C6510](../vs140/c6510.md)|Null Terminated On Non-Pointer|  
|[C6511](../vs140/c6511.md)|MustCheck Must Be Yes Or No|  
|[C6513](../vs140/c6513.md)|Element Size Without Buffer Size|  
|[C6514](../vs140/c6514.md)|Buffer Size Exceeds Array Size|  
|[C6515](../vs140/c6515.md)|Buffer Size On Non-Pointer|  
|[C6516](../vs140/c6516.md)|No Properties On Attribute|  
|[C6517](../vs140/c6517.md)|Valid Size On Non-Readable Buffer|  
|[C6518](../vs140/c6518.md)|Writable Size On Non-Writable Buffer|  
|[C6519](assetId:///2b6326b0-0539-4d26-8fb1-720114933232)|Invalid annotation: value of the 'NeedsRelease' property must be Yes or No|  
|[C6521](assetId:///e98d0ae3-6f13-47b2-9a15-15d4055af9ef)|Invalid Size String Dereference|  
|[C6522](../vs140/c6522.md)|Invalid Size String Type|  
|[C6523](assetId:///11397a31-b224-46b0-afb7-d49ca576a3bb)|Invalid Size String Parameter|  
|[C6525](../vs140/c6525.md)|Invalid Size String Unreachable Location|  
|[C6526](assetId:///59c590c7-0098-4166-a1ac-87f324596002)|Invalid Size String Buffer Type|  
|[C6527](../vs140/c6527.md)|Invalid annotation: 'NeedsRelease' property may not be used on values of void type|  
|[C6530](../vs140/c6530.md)|Unrecognized Format String Style|  
|[C6540](../vs140/c6540.md)|The use of attribute annotations on this function will invalidate all of its existing __declspec annotations|  
|[C6551](../vs140/c6551.md)|Invalid size specification: expression not parsable|  
|[C6552](../vs140/c6552.md)|Invalid Deref= or Notref=: expression not parsable|  
|[C6701](../vs140/c6701.md)|The value is not a valid Yes/No/Maybe value|  
|[C6702](../vs140/c6702.md)|The value is not a string value|  
|[C6703](../vs140/c6703.md)|The value is not a number|  
|[C6704](../vs140/c6704.md)|Unexpected Annotation Expression Error|  
|[C6705](../vs140/c6705.md)|Expected number of arguments for annotation does not match actual number of arguments for annotation|  
|[C6706](../vs140/c6706.md)|Unexpected Annotation Error for annotation|  
|[C6995](../vs140/c6995.md)|Failed to save XML Log file|  
|[C26100](../vs140/c26100.md)|Race condition|  
|[C26101](../vs140/c26101.md)|Failing to use interlocked operation properly|  
|[C26110](../vs140/c26110.md)|Caller failing to hold lock|  
|[C26111](../vs140/c26111.md)|Caller failing to release lock|  
|[C26112](../vs140/c26112.md)|Caller cannot hold any lock|  
|[C26115](../vs140/c26115.md)|Failing to release lock|  
|[C26116](../vs140/c26116.md)|Failing to acquire or to hold lock|  
|[C26117](../vs140/c26117.md)|Releasing unheld lock|  
|[C26140](../vs140/c26140.md)|Concurrency SAL annotation error|  
|[C28020](../vs140/c28020.md)|The expression is not true at this call|  
|[C28021](../vs140/c28021.md)|The parameter being annotated must be a pointer|  
|[C28022](../vs140/c28022.md)|The function class(es) on this function do not match the function class(es) on the typedef used to define it.|  
|[C28023](../vs140/c28023.md)|The function being assigned or passed should have a _Function_class\_ annotation for at least one of the class(es)|  
|[C28024](../vs140/c28024.md)|The function pointer being assigned to is annotated with the function class, which is not contained in the function class(es) list.|  
|[C28039](../vs140/c28039.md)|The type of actual parameter should exactly match the type|  
|[C28112](../vs140/c28112.md)|A variable which is accessed via an Interlocked function must always be accessed via an Interlocked function.|  
|[C28113](../vs140/c28113.md)|Accessing a local variable via an Interlocked function|  
|[C28125](../vs140/c28125.md)|The function must be called from within a try/except block|  
|[C28137](../vs140/c28137.md)|The variable argument should instead be a (literal) constant|  
|[C28138](../vs140/c28138.md)|The constant argument should instead be variable|  
|[C28159](../vs140/c28159.md)|Consider using another function instead.|  
|[C28160](../vs140/c28160.md)|Error annotation|  
|[C28163](../vs140/c28163.md)|The function should never be called from within a try/except block|  
|[C28164](../vs140/c28164.md)|The argument is being passed to a function that expects a pointer to an object (not a pointer to a pointer)|  
|[C28182](../vs140/c28182.md)|Dereferencing NULL pointer. The pointer contains the same NULL value as another pointer did.|  
|[C28183](../vs140/c28183.md)|The argument could be one value, and is a copy of the value found in the pointer|  
|[C28193](../vs140/c28193.md)|The variable holds a value that must be examined|  
|[C28196](../vs140/c28196.md)|The requirement is not satisfied. (The expression does not evaluate to true.)|  
|[C28202](../vs140/c28202.md)|Illegal reference to non-static member|  
|[C28203](../vs140/c28203.md)|Ambiguous reference to class member.|  
|[C28205](../vs140/c28205.md)|_Success\_ or _On_failure\_ used in an illegal context|  
|[C28206](../vs140/c28206.md)|Left operand points to a struct, use '->'|  
|[C28207](../vs140/c28207.md)|Left operand is a struct, use '.'|  
|[C28209](../vs140/c28209.md)|The declaration for symbol has a conflicting declaration|  
|[C28210](../vs140/c28210.md)|Annotations for the __on_failure context must not be in explicit pre context|  
|[C28211](../vs140/c28211.md)|Static context name expected for SAL_context|  
|[C28212](../vs140/c28212.md)|Pointer expression expected for annotation|  
|[C28213](../vs140/c28213.md)|The _Use_decl_annotations\_ annotation must be used to reference, without modification, a prior declaration.|  
|[C28214](../vs140/c28214.md)|Attribute parameter names must be p1...p9|  
|[C28215](../vs140/c28215.md)|The typefix cannot be applied to a parameter that already has a typefix|  
|[C28216](../vs140/c28216.md)|The checkReturn annotation only applies to postconditions for the specific function parameter.|  
|[C28217](../vs140/c28217.md)|For function, the number of parameters to annotation does not match that found at file|  
|[C28218](../vs140/c28218.md)|For function paramteer, the annotation's parameter does not match that found at file|  
|[C28219](../vs140/c28219.md)|Member of enumeration expected for annotation the parameter in the annotation|  
|[C28220](../vs140/c28220.md)|Integer expression expected for annotation the parameter in the annotation|  
|[C28221](../vs140/c28221.md)|String expression expected for the parameter in the annotation|  
|[C28222](../vs140/c28222.md)|__yes, \__no, or \__maybe expected for annotation|  
|[C28223](../vs140/c28223.md)|Did not find expected Token/identifier for annotation, parameter|  
|[C28224](../vs140/c28224.md)|Annotation requires parameters|  
|[C28225](../vs140/c28225.md)|Did not find the correct number of required parameters in annotation|  
|[C28226](../vs140/c28226.md)|Annotation cannot also be a PrimOp (in current declaration)|  
|[C28227](../vs140/c28227.md)|Annotation cannot also be a PrimOp (see prior declaration)|  
|[C28228](../vs140/c28228.md)|Annotation parameter: cannot use type in annotations|  
|[C28229](../vs140/c28229.md)|Annotation does not support parameters|  
|[C28230](../vs140/c28230.md)|The type of parameter has no member.|  
|[C28231](../vs140/c28231.md)|Annotation is only valid on array|  
|[C28232](../vs140/c28232.md)|pre, post, or deref not applied to any annotation|  
|[C28233](../vs140/c28233.md)|pre, post, or deref applied to a block|  
|[C28234](../vs140/c28234.md)|__at expression does not apply to current function|  
|[C28235](../vs140/c28235.md)|The function cannot stand alone as an annotation|  
|[C28236](../vs140/c28236.md)|The annotation cannot be used in an expression|  
|[C28237](../vs140/c28237.md)|The annotation on parameter is no longer supported|  
|[C28238](../vs140/c28238.md)|The annotation on parameter has more than one of value, stringValue, and longValue. Use paramn=xxx|  
|[C28239](../vs140/c28239.md)|The annotation on parameter has both value, stringValue, or longValue; and paramn=xxx. Use only paramn=xxx|  
|[C28240](../vs140/c28240.md)|The annotation on parameter has param2 but no param1|  
|[C28241](../vs140/c28241.md)|The annotation for function on parameter is not recognized|  
|[C28243](../vs140/c28243.md)|The annotation for function on parameter requires more dereferences than the actual type annotated allows|  
|[C28244](../vs140/c28244.md)|The annotation for function has an unparseable parameter/external annotation|  
|[C28245](../vs140/c28245.md)|The annotation for function annotates 'this' on a non-member-function|  
|[C28246](../vs140/c28246.md)|The parameter annotation for function does not match the type of the parameter|  
|[C28250](../vs140/c28250.md)|Inconsistent annotation for function: the prior instance has an error.|  
|[C28251](../vs140/c28251.md)|Inconsistent annotation for function: this instance has an error.|  
|[C28252](../vs140/c28252.md)|Inconsistent annotation for function: parameter has another annotations on this instance.|  
|[C28253](../vs140/c28253.md)|Inconsistent annotation for function: parameter has another annotations on this instance.|  
|[C28254](../vs140/c28254.md)|dynamic_cast<>() is not supported in annotations|  
|[C28262](../vs140/c28262.md)|A syntax error in the annotation was found in function, for annotation|  
|[C28263](../vs140/c28263.md)|A syntax error in a conditional annotation was found for Intrinsic annotation|  
|[C28264](assetId:///bf6ea983-a06e-4752-a042-747a7dbf338c)|Result lists values must be constants.|  
|[C28267](../vs140/c28267.md)|A syntax error in the annotations was found annotation in the function.|  
|[C28272](../vs140/c28272.md)|The annotation for function, parameter when examining is inconsistent with the function declaration|  
|[C28273](../vs140/c28273.md)|For function, the clues are inconsistent with the function declaration|  
|[C28275](../vs140/c28275.md)|The parameter to _Macro_value\_ is null|  
|[C28279](../vs140/c28279.md)|For symbol, a 'begin' was found without a matching 'end'|  
|[C28280](../vs140/c28280.md)|For symbol, an 'end' was found without a matching 'begin'|  
|[C28282](../vs140/c28282.md)|Format Strings must be in preconditions|  
|[C28285](../vs140/c28285.md)|For function, syntax error in parameter|  
|[C28286](../vs140/c28286.md)|For function, syntax error near the end|  
|[C28287](../vs140/c28287.md)|For function, syntax Error in _At\_() annotation (unrecognized parameter name)|  
|[C28288](../vs140/c28288.md)|For function, syntax Error in _At\_() annotation (invalid parameter name)|  
|[C28289](../vs140/c28289.md)|For function: ReadableTo or WritableTo did not have a limit-spec as a parameter|  
|[C28290](../vs140/c28290.md)|the annotation for function contains more Externals than the actual number of parameters|  
|[C28291](../vs140/c28291.md)|post null/notnull at deref level 0 is meaningless for function.|  
|[C28300](../vs140/c28300.md)|Expression operands of incompatible types for operator|  
|[C28301](../vs140/c28301.md)|No annotations for first declaration of function.|  
|[C28302](../vs140/c28302.md)|An extra _Deref\_ operator was found on annotation.|  
|[C28303](../vs140/c28303.md)|An ambiguous _Deref\_ operator was found on annotation.|  
|[C28304](../vs140/c28304.md)|An improperly placed _Notref\_ operator was found applied to token.|  
|[C28305](../vs140/c28305.md)|An error while parsing a token was discovered.|  
|[C28306](../vs140/c28306.md)|The annotation on parameter is obsolescent|  
|[C28307](../vs140/c28307.md)|The annotation on parameter is obsolescent|  
|[C28350](../vs140/c28350.md)|The annotation describes a situation that is not conditionally applicable.|  
|[C28351](../vs140/c28351.md)|The annotation describes where a dynamic value (a variable) cannot be used in the condition.|