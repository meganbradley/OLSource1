---
title: "Command-Line Warning D9027"
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
  - "D9027"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "D9027"
ms.assetid: 2a29edc5-5649-48f2-9058-2057c747284c
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Command-Line Warning D9027
source file '\<filename>' ignored  
  
 CL.exe ignored the input source file.  
  
 This warning can be caused by a space between the /Fo option and an output filename on a command line with the /c option. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Because there is a space between /Fo and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> CL.exe takes <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> as the name of the input file. To fix the problem, remove the space:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>