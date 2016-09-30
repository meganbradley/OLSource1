---
title: "Fatal Error C1005"
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
  - "C1005"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C1005"
ms.assetid: 150daf8e-a38a-4669-9c1a-a05b5a1f65ef
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Fatal Error C1005
string too big for buffer  
  
 A string in a compiler intermediate file overflowed a buffer.  
  
 You could get this error when the parameter that you pass to either the [/Fd](../vs140/-fd--program-database-file-name-.md) or [/Yl](../vs140/-yl--inject-pch-reference-for-debug-library-.md) compiler options is greater than 256 bytes.