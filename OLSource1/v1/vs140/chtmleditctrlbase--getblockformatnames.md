---
title: "CHtmlEditCtrlBase::GetBlockFormatNames"
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
  - "GetBlockFormatNames"
  - "CHtmlEditCtrlBase::GetBlockFormatNames"
  - "CHtmlEditCtrlBase.GetBlockFormatNames"
  - "CHtmlEditCtrlBase<T>::GetBlockFormatNames"
  - "CHtmlEditCtrlBase<T>.GetBlockFormatNames"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetBlockFormatNames method"
ms.assetid: b9792099-6aa2-48ab-82c0-7176c2b460d6
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::GetBlockFormatNames
Retrieves the strings corresponding to the available block format tags.  
  
## Syntax  
  
```  
  
      HRESULT GetBlockFormatNames(  
   CStringArray& sa   
) const;  
```  
  
#### Parameters  
 *sa*  
 The available block format tags, as an array of strings.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM_GETBLOCKFMTS command ID](https://msdn.microsoft.com/en-us/library/aa769884.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)   
 [CHtmlEditCtrlBase::GetBlockFormat](../vs140/chtmleditctrlbase--getblockformat.md)