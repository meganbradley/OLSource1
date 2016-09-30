---
title: "Compiler Warning (level 1) C4291"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C4291"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4291"
ms.assetid: c2b95dea-38f2-4609-9104-707c30798da4
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4291
'declaration' : no matching operator delete found; memory will not be freed if initialization throws an exception  
  
 A placement [new](../vs140/new-operator--c---.md) is used for which there is no placement [delete](../vs140/delete-operator--c---.md).  
  
 When memory is allocated for an object with operator **new**, the object's constructor is called. If the constructor throws an exception, any memory that was allocated for the object should be deallocated. This cannot take place unless an operator **delete** function exists that matches the operator **new**.  
  
 If you use the operator **new** without any extra arguments and compile with [/GX](../vs140/-gx--enable-exception-handling-.md), [/EHs](../vs140/-eh--exception-handling-model-.md), or /EHa options to enable exception handling, the compiler will generate code to call operator **delete** if the constructor throws an exception.  
  
 If you use the placement form of the **new** operator (the form with arguments in addition to the size of the allocation) and the object's constructor throws an exception, the compiler will still generate code to call operator **delete**; but it will only do so if a placement form of operator **delete** exists matching the placement form of the operator **new** that allocated the memory. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The above example generates warning C4291 because no placement form of operator **delete** has been defined that matches the placement form of operator **new**. To solve the problem, insert the following code above **main**. Notice that all of the overloaded operator **delete** function parameters match those of the overloaded operator **new**, except for the first parameter.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>