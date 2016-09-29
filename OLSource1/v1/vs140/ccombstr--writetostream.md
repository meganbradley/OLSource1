---
title: "CComBSTR::WriteToStream"
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
  - "ATL.CComBSTR.WriteToStream"
  - "CComBSTR.WriteToStream"
  - "CComBSTR::WriteToStream"
  - "WriteToStream"
  - "ATL::CComBSTR::WriteToStream"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WriteToStream method"
ms.assetid: 382d86dd-ef93-44e2-b8cc-45b183842b0f
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComBSTR::WriteToStream
Saves the [m_str](../vs140/ccombstr--m_str.md) member to a stream.  
  
## Syntax  
  
```  
  
      HRESULT WriteToStream(  
   IStream* pStream   
) throw( );  
```  
  
#### Parameters  
 `pStream`  
 [in] A pointer to the [IStream](http://msdn.microsoft.com/library/windows/desktop/aa380034) interface on a stream.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Remarks  
 You can recreate a BSTR from the contents of the stream using the [ReadFromStream](../vs140/ccombstr--readfromstream.md) function.  
  
## Example  
 [!code[NVC_ATL_Utilities#45](../vs140/codesnippet/CPP/ccombstr--writetostream_1.cpp)]  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComBSTR Class](../vs140/ccombstr-class.md)   
 [CComBSTR::ReadFromStream](../vs140/ccombstr--readfromstream.md)