---
title: "CIPAddressCtrl::SetAddress"
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
  - "CIPAddressCtrl.SetAddress"
  - "SetAddress"
  - "CIPAddressCtrl::SetAddress"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetAddress method"
ms.assetid: a685f695-08c4-487e-86b0-5b0826b73cba
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CIPAddressCtrl::SetAddress
Sets the address values for all four fields in the IP Address Control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The field 0 value from a packed IP address.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The field 1 value from a packed IP address.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The field 2 value from a packed IP address.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The field 3 value from a packed IP address.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> value that contains the new IP address. See **Remarks** for a table that shows how the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> value is filled.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [IPM_SETADDRESS](http://msdn.microsoft.com/library/windows/desktop/bb761380), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. In the first prototype above, the numbers in fields 0 through 3 of the control, read left to right respectively, populate the four parameters. In the second prototype above, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is populated as follows.  
  
|Field|Bits containing the field value|  
|-----------|-------------------------------------|  
|0|24 through 31|  
|1|16 through 23|  
|2|8 through 15|  
|3|0 through 7|  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CIPAddressCtrl Class](../vs140/cipaddressctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CIPAddressCtrl::GetAddress](../vs140/cipaddressctrl--getaddress.md)   
 [CIPAddressCtrl::ClearAddress](../vs140/cipaddressctrl--clearaddress.md)