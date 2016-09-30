---
title: "CDaoException::m_pErrorInfo"
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
  - "m_pErrorInfo"
  - "CDaoException.m_pErrorInfo"
  - "CDaoException::m_pErrorInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDaoErrorInfo structure"
  - "DAO (Data Access Objects), error information"
  - "MFC, DAO"
  - "m_pErrorInfo"
  - "errors [C++], MFC DAO"
  - "exceptions, getting error information"
ms.assetid: b1dfb865-245a-4b2c-895d-f6341c05b371
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoException::m_pErrorInfo
Contains a pointer to a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> structure that provides information on the DAO error object that you last retrieved by calling [GetErrorInfo](../vs140/cdaoexception--geterrorinfo.md).  
  
## Remarks  
 This object contains the following information:  
  
|CDaoErrorInfo member|Information|Meaning|  
|--------------------------|-----------------|-------------|  
|**m_lErrorCode**|Error Code|The DAO error code|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Source|The name of the object or application that originally generated the error|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Description|A descriptive string associated with the error|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Help File|A path to a Windows Help file in which the user can get information about the problem|  
|**m_lHelpContext**|Help Context|The context ID for a topic in the DAO Help file|  
  
 For full details about the information contained in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object, see the [CDaoErrorInfo](../vs140/cdaoerrorinfo-structure.md) structure.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoException Class](../vs140/cdaoexception-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoException::m_scode](../vs140/cdaoexception--m_scode.md)   
 [CDaoException::m_nAfxDaoError](../vs140/cdaoexception--m_nafxdaoerror.md)