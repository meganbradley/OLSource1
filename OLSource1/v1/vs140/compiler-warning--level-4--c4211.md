---
title: "Compiler Warning (level 4) C4211"
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
  - "C4211"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4211"
ms.assetid: 3eea3455-6faa-4cdb-8730-73db7026bd1f
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) C4211
nonstandard extension used : redefined extern to static  
  
 With the default Microsoft extensions (/Ze), you can redefine an <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> identifier as **static**.  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Such redefinitions are invalid under ANSI compatibility ([/Za](../vs140/-za---ze--disable-language-extensions-.md)).  
  
## See Also  
 [(NOTINBUILD)Static Storage-Class Specifiers](assetId:///3ba9289a-a412-4a17-b319-ceb2c087df48)