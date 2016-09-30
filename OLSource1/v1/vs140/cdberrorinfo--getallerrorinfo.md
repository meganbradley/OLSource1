---
title: "CDBErrorInfo::GetAllErrorInfo"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "ATL.CDBErrorInfo.GetAllErrorInfo"
  - "CDBErrorInfo::GetAllErrorInfo"
  - "ATL::CDBErrorInfo::GetAllErrorInfo"
  - "GetAllErrorInfo"
  - "CDBErrorInfo.GetAllErrorInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetAllErrorInfo method"
ms.assetid: 630049fa-d296-497a-bbf6-f5d3d71d271d
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDBErrorInfo::GetAllErrorInfo
Returns all the types of error information contained in an error record.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *ulRecordNum*  
 [in] The zero-based number of the record for which to return error information.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The locale ID for the error information to be returned.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] A pointer to a text description of the error or NULL if the locale is not supported. See Remarks.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] A pointer to a string containing the name of the component that generated the error.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [out] A pointer to the GUID of the interface that defined the error.  
  
 *pdwHelpContext*  
 [out] A pointer to the help context ID for the error.  
  
 *pbstrHelpFile*  
 [out] A pointer to a string containing the path to the help file that describes the error.  
  
## Return Value  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if successful. See [IErrorRecords::GetErrorInfo](https://msdn.microsoft.com/en-us/library/ms711230.aspx) in the *OLE DB Programmer's Reference* for other return values.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## Remarks  
 The output value of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is obtained internally by calling IErrorInfo::GetDescription, which sets the value to NULL if the locale is not supported, or if both of the following conditions are true:  
  
1.  the value of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is NOT U.S. English and  
  
2.  the value of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is NOT equal to the value returned by GetUserDefaultLCID.  
  
## See Also  
 [CDBErrorInfo Class](../vs140/cdberrorinfo-class.md)