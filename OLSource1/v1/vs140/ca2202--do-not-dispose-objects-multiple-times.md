---
title: "CA2202: Do not dispose objects multiple times"
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
  - "CA2202"
  - "Do not dispose objects multiple times"
  - "DoNotDisposeObjectsMultipleTimes"
helpviewer_keywords: 
  - "CA2202"
ms.assetid: fa85349a-cf1e-42c8-a86b-eacae1f8bd96
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA2202: Do not dispose objects multiple times
|||  
|-|-|  
|TypeName|DoNotDisposeObjectsMultipleTimes|  
|CheckId|CA2202|  
|Category|Microsoft.Usage|  
|Breaking Change|Non Breaking|  
  
## Cause  
 A method implementation contains code paths that could cause multiple calls to \<xref:System.IDisposable.Dispose*?displayProperty=fullName> or a Dispose equivalent, such as a Close() method on some types, on the same object.  
  
## Rule Description  
 A correctly implemented \<xref:System.IDisposable.Dispose*> method can be called multiple times without throwing an exception. However, this is not guaranteed and to avoid generating a \<xref:System.ObjectDisposedException*?displayProperty=fullName> you should not call \<xref:System.IDisposable.Dispose*> more than one time on an object.  
  
## Related Rules  
 [CA2000: Dispose objects before losing scope](../vs140/ca2000--dispose-objects-before-losing-scope.md)  
  
## How to Fix Violations  
 To fix a violation of this rule, change the implementation so that regardless of the code path, \<xref:System.IDisposable.Dispose*> is called only one time for the object.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule. Even if \<xref:System.IDisposable.Dispose*> for the object is known to be safely callable multiple times, the implementation might change in the future.  
  
## Example  
 Nested <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> statements (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> in Visual Basic) can cause violations of the CA2202 warning. If the IDisposable resource of the nested inner <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statement contains the resource of the outer <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statement, the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method of the nested resource releases the contained resource. When this situation occurs, the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> method of the outer <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> statement attempts to dispose its resource for a second time.  
  
 In the following example, a \<xref:System.IO.Stream*> object that is created in an outer using statement is released at the end of the inner using statement in the Dispose method of the \<xref:System.IO.StreamWriter*> object that contains the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object. At the end of the outer <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> statement, the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object is released a second time. The second release is a violation of CA2202.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 To resolve this issue, use a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>/<CodeContentPlaceHolder>13\</CodeContentPlaceHolder> block instead of the outer <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> statement. In the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> block, make sure that the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> resource is not null.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 \<xref:System.IDisposable*?displayProperty=fullName>   
 [Implementing Finalize and Dispose](assetId:///31a6c13b-d6a2-492b-9a9f-e5238c983bcb)