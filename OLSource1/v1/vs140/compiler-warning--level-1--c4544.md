---
title: "Compiler Warning (level 1) C4544"
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
  - "C4544"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4544"
ms.assetid: 11ee04df-41ae-435f-af44-881e801315a8
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4544
'declaration': Default template argument ignored on this template declaration  
  
 A default template argument was specified in an incorrect location and was ignored. A default template argument for a class template can only be specified in the declaration or definition of the class template and not on a member of the class template.  
  
 This sample generates C4545, and the next sample shows how to fix it:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In this example, the default parameter applies to class template <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>