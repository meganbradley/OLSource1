---
title: "CWinApp::GetProfileInt"
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
  - "CWinApp.GetProfileInt"
  - "CWinApp::GetProfileInt"
  - "GetProfileInt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CWinApp class, operations"
  - "profile integers"
  - "GetProfileInt method"
  - "registry, reading"
ms.assetid: d3bdb3b1-a7c3-4151-a5b6-45beca2f76e1
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::GetProfileInt
Call this member function to retrieve the value of an integer from an entry within a specified section of the application's registry or .INI file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to a null-terminated string that specifies the section containing the entry.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Points to a null-terminated string that contains the entry whose value is to be retrieved.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the default value to return if the framework cannot find the entry.  
  
## Return Value  
 The integer value of the string that follows the specified entry if the function is successful. The return value is the value of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter if the function does not find the entry. The return value is 0 if the value that corresponds to the specified entry is not an integer.  
  
 This member function supports hexadecimal notation for the value in the .INI file. When you retrieve a signed integer, you should cast the value into an <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 This member function is not case sensitive, so the strings in the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameters may differ in case.  
  
> [!IMPORTANT]
>  The data returned by this function is not necessarily NULL terminated, and the caller must perform validation. For more information, see [Avoiding Buffer Overruns](http://msdn.microsoft.com/library/windows/desktop/ms717795).  
  
## Example  
 [!code[NVC_MFCWindowing#42](../vs140/codesnippet/CPP/cwinapp--getprofileint_1.cpp)]  
  
 For an additional example, see [CWinApp::WriteProfileInt](../vs140/cwinapp--writeprofileint.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::GetProfileString](../vs140/cwinapp--getprofilestring.md)   
 [CWinApp::WriteProfileInt](../vs140/cwinapp--writeprofileint.md)   
 [GetPrivateProfileInt](http://msdn.microsoft.com/library/windows/desktop/ms724345)