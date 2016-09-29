---
title: "Fatal Error C1071"
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
  - "C1071"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C1071"
ms.assetid: 489f1786-370e-4ecd-af67-538fe6e5bd4e
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Fatal Error C1071
unexpected end of file found in comment  
  
 The compiler reached the end of the file while scanning a comment.  
  
### To fix by checking the following possible causes  
  
1.  Missing comment terminator (*/).  
  
2.  Missing newline character after a comment on the last line of a source file.  
  
 The following sample generates C1071:  
  
```  
// C1071.cpp  
int main() {  
}  
  
/* this comment is fine */  
/* forgot the closing tag        // C1071  
```