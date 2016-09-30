---
title: "Compiler Error C3818"
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
  - "C3818"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3818"
ms.assetid: f9502f6a-0690-4135-ab88-cc97cf490f5c
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3818
array property declaration 'property1' shall not overload an index property 'property2'  
  
 An overload is not possible for properties when one is an indexer and the other is an array property. See [__property](../vs140/__property.md) for more information.  
  
 C3818 is only reachable using **/clr:oldSyntax**.  
  
 The following sample generates C3818:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>