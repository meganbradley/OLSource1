---
title: "CWinApp::GetProfileBinary"
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
  - "CWinApp.GetProfileBinary"
  - "GetProfileBinary"
  - "CWinApp::GetProfileBinary"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CWinApp class, operations"
  - "GetProfileBinary method"
  - "profile binary data"
  - "registry, reading"
ms.assetid: cd8af8a3-ed24-4691-a631-a33baba1464c
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::GetProfileBinary
Call this member function to retrieve binary data from an entry within a specified section of the application's registry or .INI file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *lpszSection*  
 Points to a null-terminated string that specifies the section containing the entry.  
  
 *lpszEntry*  
 Points to a null-terminated string that contains the entry whose value is to be retrieved.  
  
 *ppData*  
 Points to a pointer that will receive the address of the data.  
  
 *pBytes*  
 Points to a UINT that will receive the size of the data (in bytes).  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 This member function is not case sensitive, so the strings in the *lpszSection* and *lpszEntry* parameters may differ in case.  
  
> [!NOTE]
>  **GetProfileBinary** allocates a buffer and returns its address in \**ppData*. The caller is responsible for freeing the buffer using **delete []**.  
  
> [!IMPORTANT]
>  The data returned by this function is not necessarily NULL terminated, and the caller must perform validation. For more information, see [Avoiding Buffer Overruns](http://msdn.microsoft.com/library/windows/desktop/ms717795).  
  
## Example  
 [!code[NVC_MFCWindowing#41](../vs140/codesnippet/CPP/cwinapp--getprofilebinary_1.cpp)]  
  
 For an additional example, see [CWinApp::WriteProfileBinary](../vs140/cwinapp--writeprofilebinary.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::GetProfileInt](../vs140/cwinapp--getprofileint.md)   
 [CWinApp::GetProfileString](../vs140/cwinapp--getprofilestring.md)