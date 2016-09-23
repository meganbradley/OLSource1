---
title: "CA1407: Avoid static members in COM visible types"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - CA1407
  - AvoidStaticMembersInComVisibleTypes
helpviewer_keywords: 
  - CA1407
  - AvoidStaticMembersInComVisibleTypes
ms.assetid: bebd0776-ad04-453c-bca8-8c124c2d7840
caps.latest.revision: 27
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CA1407: Avoid static members in COM visible types
|||  
|-|-|  
|TypeName|AvoidStaticMembersInComVisibleTypes|  
|CheckId|CA1407|  
|Category|Microsoft.Interoperability|  
|Breaking Change|Non-breaking|  
  
## Cause  
 A type that is specifically marked as visible to Component Object Model (COM) contains a `public``static` method.  
  
## Rule Description  
 COM does not support `static` methods.  
  
 This rule ignores property and event accessors, operator overloading methods, or methods that are marked by using either the <xref:System.Runtime.InteropServices.ComRegisterFunctionAttribute?qualifyHint=True> attribute or the <xref:System.Runtime.InteropServices.ComUnregisterFunctionAttribute?qualifyHint=True> attribute.  
  
 By default, the following are visible to COM: assemblies, public types, public instance members in public types, and all members of public value types.  
  
 For this rule to occur, an assembly-level <xref:System.Runtime.InteropServices.ComVisibleAttribute?qualifyHint=False> must be set to `false` and the class- <xref:System.Runtime.InteropServices.ComVisibleAttribute?qualifyHint=False> must be set to `true`, as the following code shows.  
  
```c#  
using System;  
using System.Runtime.InteropServices;   
  
[assembly: ComVisible(false)]   
namespace Samples  
{      
    [ComVisible(true)]  
    public class MyClass  
    {  
        public static void DoSomething()  
        {  
        }  
    }  
}  
```  
  
## How to Fix Violations  
 To fix a violation of this rule, change the design to use an instance method that provides the same functionality as the `static` method.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if a COM client does not require access to the functionality that is provided by the `static` method.  
  
## Example Violation  
  
### Description  
 The following example shows a `static` method that violates this rule.  
  
### Code  
 [!code[FxCop.Interoperability.ComVisibleStaticMembersViolation#1](../vs140/codesnippet/CSharp/ca1407--avoid-static-members-in-com-visible-types_1.cs)]
  
  
### Comments  
 In this example, the **Book.FromPages** method cannot be called from COM.  
  
## Example Fix  
  
### Description  
 To fix the violation in the previous example, you could change the method to an instance method, but that does not make sense in this instance. A better solution is to explicitly apply `ComVisible(false)` to the method to make it clear to other developers that the method cannot be seen from COM.  
  
 The following example applies <xref:System.Runtime.InteropServices.ComRegisterFunctionAttribute?qualifyHint=False> to the method.  
  
### Code  
 [!code[FxCop.Interoperability.ComVisibleStaticMembersFixed#1](../vs140/codesnippet/CSharp/ca1407--avoid-static-members-in-com-visible-types_2.cs)]
  
  
## Related Rules  
 [Mark assemblies with ComVisible](../vs140/ca1017--mark-assemblies-with-comvisibleattribute.md)  
  
 [Avoid int64 arguments for VB6 clients](../vs140/ca1406--avoid-int64-arguments-for-visual-basic-6-clients.md)  
  
 [Avoid non-public fields in ComVisible value types](../vs140/ca1413--avoid-non-public-fields-in-com-visible-value-types.md)  
  
## See Also  
 [Interoperating with Unmanaged Code](assetId:///ccb68ce7-b0e9-4ffb-839d-03b1cd2c1258)