---
title: "NMAKE Fatal Error U1045"
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
  - "U1045"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "U1045"
ms.assetid: dc70d162-14b9-4107-9237-7514044d72e3
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# NMAKE Fatal Error U1045
spawn failed : message  
  
 A program or command called by NMAKE failed for the given reason. When NMAKE calls another program—for example, the compiler or linker—the call may fail, or an error may be returned by the called program. This message is used to report the error.  
  
 To fix this issue, first determine the cause of the error. You can use the commands reported by the NMAKE [/N](../vs140/nmake-options.md) option to verify the environment settings and to repeat the actions performed by NMAKE on the command line.