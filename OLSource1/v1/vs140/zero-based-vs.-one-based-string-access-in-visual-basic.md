---
title: "Zero-based vs. One-based String Access in Visual Basic"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "strings [Visual Basic], indexing"
ms.assetid: 0ed39f35-d68e-421d-ae14-460a5c0373b8
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Zero-based vs. One-based String Access in Visual Basic
This topic compares how [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] and the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] provide access to the characters in a string. The [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] always provides zero-based access to the characters in a string, whereas [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] provides zero-based and one-based access, depending on the function.  
  
## One-Based  
 For an example of a one-based [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] function, consider the `Mid` function. It takes an argument that indicates the character position at which the substring will start, starting with position 1. The [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] [String.Substring](assetId:///M:System.String.Substring(System.Int32)?qualifyHint=True&autoUpgrade=True) method takes an index of the character in the string at which the substring is to start, starting with position 0. Thus, if you have a string "ABCDE", the individual characters are numbered 1,2,3,4,5 for use with the `Mid` function, but 0,1,2,3,4 for use with the assetId:///M:System.String.Substring(System.Int32)?qualifyHint=True&autoUpgrade=True method.  
  
## Zero-Based  
 For an example of a zero-based [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] function, consider the `Split` function. It splits a string and returns an array containing the substrings. The [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] [String.Split](assetId:///M:System.String.Split(System.Char[])?qualifyHint=True&autoUpgrade=True) method also splits a string and returns an array containing the substrings. Because the `Split` function and [Split](assetId:///M:System.String.Split(System.Char[])?qualifyHint=False&autoUpgrade=True) method return [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] arrays, they must be zero-based.  
  
## See Also  
 [Mid](assetId:///M:Microsoft.VisualBasic.Strings.Mid(System.String,System.Int32)?qualifyHint=False&autoUpgrade=True)   
 [Split](assetId:///M:Microsoft.VisualBasic.Strings.Split(System.String,System.String,System.Int32,Microsoft.VisualBasic.CompareMethod)?qualifyHint=False&autoUpgrade=True)   
 [Substring](assetId:///M:System.String.Substring(System.Int32)?qualifyHint=False&autoUpgrade=True)   
 assetId:///M:System.String.Split(System.Char[])?qualifyHint=False&autoUpgrade=True   
 [Introduction to Strings in Visual Basic](../vs140/introduction-to-strings-in-visual-basic.md)