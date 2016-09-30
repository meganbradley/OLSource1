---
title: "Compiler Warning (level 4) C4221"
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
  - "C4221"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4221"
ms.assetid: 8532bd68-54dc-4526-8597-f61dcb0a0129
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) C4221
nonstandard extension used : 'identifier' : cannot be initialized using address of automatic variable  
  
 With the default Microsoft extensions (/Ze), you can initialize an aggregate type (**array**, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, or **union**) with the address of a local (automatic) variable.  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Such initializations are invalid under ANSI compatibility ([/Za](../vs140/-za---ze--disable-language-extensions-.md)).