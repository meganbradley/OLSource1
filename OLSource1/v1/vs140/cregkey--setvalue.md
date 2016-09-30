---
title: "CRegKey::SetValue"
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
  - "CRegKey.SetValue"
  - "ATL.CRegKey.SetValue"
  - "SetValue"
  - "CRegKey::SetValue"
  - "ATL::CRegKey::SetValue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "registry, writing to"
  - "SetValue method"
ms.assetid: 7db96d87-3aa2-48c6-ba57-47dbbef16887
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRegKey::SetValue
Call this method to store data in the specified value field of [m_hKey](../vs140/cregkey--m_hkey.md). Earlier versions of this method are no longer supported and are marked as **ATL_DEPRECATED**.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to a string containing the name of the value to set. If a value with this name is not already present in the key, the method adds it to the key. If <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is NULL or an empty string, "", the method sets the type and data for the key's unnamed or default value.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies a code indicating the type of data pointed to by the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Pointer to a buffer containing the data to be stored with the specified value name.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifies the size, in bytes, of the information pointed to by the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter. If the data is of type REG_SZ, REG_EXPAND_SZ, or REG_MULTI_SZ, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> must include the size of the terminating null character.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The handle of an open key.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Specifies the name of a key to be created or opened. This name must be a subkey of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Specifies the data to be stored. This parameter must be non-NULL.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Specifies the value field to be set. If a value field with this name does not already exist in the key, it is added.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 Specifies the data to be stored.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 If false, indicates the string is of type REG_SZ. If true, indicates the string is a multistring of type REG_MULTI_SZ.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is true, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is the length of the *lpszValue* string in characters. If <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is false, a value of -1 indicates that the method will calculate the length automatically.  
  
## Return Value  
 If successful, returns ERROR_SUCCESS; otherwise, a nonzero error code defined in WINERROR.H.  
  
## Remarks  
 The two original versions of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> are marked as **ATL_DEPRECATED** and should no longer be used. The compiler will issue a warning if these forms are used.  
  
 The third method calls [RegSetValueEx](http://msdn.microsoft.com/library/windows/desktop/ms724923).  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CRegKey Class](../vs140/cregkey-class.md)   
 [CRegKey::SetKeyValue](../vs140/cregkey--setkeyvalue.md)   
 [CRegKey::QueryValue](../vs140/cregkey--queryvalue.md)   
 [Registry Value Types](http://msdn.microsoft.com/library/windows/desktop/ms724884)