---
title: "CA2002: Do not lock on objects with weak identity"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "DoNotLockOnObjectsWithWeakIdentity"
  - "CA2002"
helpviewer_keywords: 
  - "CA2002"
  - "DoNotLockOnObjectsWithWeakIdentity"
ms.assetid: 16100b39-c6fc-452b-8fca-8b459a26c286
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA2002: Do not lock on objects with weak identity
|||  
|-|-|  
|TypeName|DoNotLockOnObjectsWithWeakIdentity|  
|CheckId|CA2002|  
|Category|Microsoft.Reliability|  
|Breaking Change|Non-breaking|  
  
## Cause  
 A thread attempts to acquire a lock on an object that has a weak identity.  
  
## Rule Description  
 An object is said to have a weak identity when it can be directly accessed across application domain boundaries. A thread that tries to acquire a lock on an object that has a weak identity can be blocked by a second thread in a different application domain that has a lock on the same object. The following types have a weak identity and are flagged by the rule:  
  
-   <xref:System.MarshalByRefObject*>  
  
-   <xref:System.ExecutionEngineException*>  
  
-   <xref:System.OutOfMemoryException*>  
  
-   <xref:System.StackOverflowException*>  
  
-   <xref:System.String*>  
  
-   <xref:System.Reflection.MemberInfo*>  
  
-   <xref:System.Reflection.ParameterInfo*>  
  
-   <xref:System.Threading.Thread*>  
  
## How to Fix Violations  
 To fix a violation of this rule, use an object from a type that is not in the list in the Description section.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Related Rules  
 [Disposable fields should be disposed](../vs140/ca2213--disposable-fields-should-be-disposed.md)  
  
## Example  
 The following example shows some object locks that violate the rule.  
  
 [!code[FxCop.Reliability.LockWeakObjects#1](../vs140/codesnippet/VisualBasic/ca2002--do-not-lock-on-objects-with-weak-identity_1.vb)]
[!code[FxCop.Reliability.LockWeakObjects#1](../vs140/codesnippet/CSharp/ca2002--do-not-lock-on-objects-with-weak-identity_1.cs)]  
  
## See Also  
 <xref:System.Threading.Monitor*>   
 <xref:System.AppDomain*>   
 [C# Lock Statement](../vs140/lock-statement--csharp-reference-.md)   
 [Visual Basic SyncLock Statement](../vs140/synclock-statement.md)