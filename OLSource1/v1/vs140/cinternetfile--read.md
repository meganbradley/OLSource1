---
title: "CInternetFile::Read"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CInternetFile::Read"
  - "CInternetFile.Read"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CInternetFile class, operations"
  - "Internet files, reading"
  - "Read method"
ms.assetid: 5d084d6a-ec22-49e2-b065-6fd76f33d46e
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CInternetFile::Read
Call this member function to read into the given memory, starting at `lpvBuf`, the specified number of bytes, `nCount`.  
  
## Syntax  
  
```  
  
      virtual UINT Read(   
   void* lpBuf,   
   UINT nCount    
);  
```  
  
#### Parameters  
 `lpBuf`  
 A pointer to a memory address to which file data is read.  
  
 `nCount`  
 The number of bytes to be written.  
  
## Return Value  
 The number of bytes transferred to the buffer. The return value may be less than `nCount` if the end of file was reached.  
  
## Remarks  
 The function returns the number of bytes actually read — a number that may be less than `nCount` if the file ends. If an error occurs while reading the file, the function throws a [CInternetException](../vs140/cinternetexception-class.md) object that describes the error. Note that reading past the end of the file is not considered an error and no exception will be thrown.  
  
 To ensure all data is retrieved, an application must continue to call the **CInternetFile::Read** method until the method returns zero.  
  
## Exceptions  
 This method can throw exceptions of type `CInternetException*`.  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CInternetFile Class](../vs140/cinternetfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)