---
title: "CAtlException Class"
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
  - "CAtlException"
  - "ATL::CAtlException"
  - "ATL.CAtlException"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAtlException class"
ms.assetid: 3fd7b041-f70d-4292-b947-0d70781d95a8
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlException Class
This class defines an ATL exception.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CAtlException::CAtlException](../vs140/catlexception--catlexception.md)|The constructor.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CAtlException::operator HRESULT](../vs140/catlexception--operator-hresult.md)|Casts the current object to an HRESULT value.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CAtlException::m_hr](../vs140/catlexception--m_hr.md)|The variable of type HRESULT created by the object and used to store the error condition.|  
  
## Remarks  
 A <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object represents an exception condition related to an ATL operation. The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> class includes a public data member that stores the status code indicating the reason for the exception and a cast operator that allows you to treat the exception as if it were an HRESULT.  
  
 In general, you will call <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> rather than creating a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object directly.  
  
## Requirements  
 **Header:** atlexcept.h  
  
##  \<a name="catlexception__catlexception">\</a>  CAtlException::CAtlException  
 The constructor.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> error code.  
  
##  \<a name="catlexception__operator_hresult">\</a>  CAtlException::operator HRESULT  
 Casts the current object to an HRESULT value.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="catlexception__m_hr">\</a>  CAtlException::m_hr  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> data member.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 The data member that stores the error condition. The HRESULT value is set by the constructor, [CAtlException::CAtlException](../vs140/catlexception--catlexception.md).  
  
## See Also  
 [AtlThrow](../vs140/atlthrow.md)   
 [Class Overview](../vs140/atl-class-overview.md)