---
title: "Compiler Warning (level 1) CS0684"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CS0684"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0684"
ms.assetid: d6c8aaf6-c1cf-4c0e-b367-4c3e418d8bc4
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) CS0684
'interface' interface marked with 'CoClassAttribute' not marked with 'ComImportAttribute'  
  
 If you specify **CoClassAttribute** on an interface, you must also specify **ComImportAttribute**.  
  
 The following sample generates CS0684:  
  
```  
// CS0684.cs  
// compile with: /W:1  
using System;  
using System.Runtime.InteropServices;  
  
[CoClass(typeof(C))] // CS0684  
// try the following line instead  
// [CoClass(typeof(C)), ComImport]  
interface I  
{  
}  
  
class C  
{  
   static void Main() {}  
}  
```