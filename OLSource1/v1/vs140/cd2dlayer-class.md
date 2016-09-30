---
title: "CD2DLayer Class"
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
  - "afxrendertarget/CD2DLayer"
  - "CD2DLayer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CD2DLayer class"
ms.assetid: 2f96378e-66bb-40d1-9661-6afe324de3c1
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DLayer Class
A wrapper for ID2D1Layer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DLayer::CD2DLayer](#cd2dlayer__cd2dlayer)|Constructs a CD2DLayer object.|  
|[CD2DLayer::~CD2DLayer](#cd2dlayer___dtorcd2dlayer)|The destructor. Called when a D2D layer object is being destroyed.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DLayer::Attach](#cd2dlayer__attach)|Attaches existing resource interface to the object|  
|[CD2DLayer::Create](#cd2dlayer__create)|Creates a CD2DLayer. (Overrides [CD2DResource::Create](../vs140/cd2dresource-class.md#cd2dresource__create).)|  
|[CD2DLayer::Destroy](#cd2dlayer__destroy)|Destroys a CD2DLayer object. (Overrides [CD2DResource::Destroy](../vs140/cd2dresource-class.md#cd2dresource__destroy).)|  
|[CD2DLayer::Detach](#cd2dlayer__detach)|Detaches resource interface from the object|  
|[CD2DLayer::Get](#cd2dlayer__get)|Returns ID2D1Layer interface|  
|[CD2DLayer::GetSize](#cd2dlayer__getsize)|Returns the size of the render target in device-independent pixels|  
|[CD2DLayer::IsValid](#cd2dlayer__isvalid)|Checks resource validity (Overrides [CD2DResource::IsValid](../vs140/cd2dresource-class.md#cd2dresource__isvalid).)|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DLayer::operator ID2D1Layer*](#cd2dlayer__operator_id2d1layer_star)|Returns ID2D1Layer interface|  
  
### Protected Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DLayer::m_pLayer](#cd2dlayer__m_player)|Stores a pointer to an ID2D1Layer object.|  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CD2DResource](../vs140/cd2dresource-class.md)  
  
 [CD2DLayer](../vs140/cd2dlayer-class.md)  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
##  \<a name="cd2dlayer___dtorcd2dlayer">\</a>  CD2DLayer::~CD2DLayer  
 The destructor. Called when a D2D layer object is being destroyed.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="cd2dlayer__attach">\</a>  CD2DLayer::Attach  
 Attaches existing resource interface to the object  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Existing resource interface. Cannot be NULL  
  
##  \<a name="cd2dlayer__cd2dlayer">\</a>  CD2DLayer::CD2DLayer  
 Constructs a CD2DLayer object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 A pointer to the render target.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 Indicates that the object will be destroyed by owner (pParentTarget).  
  
##  \<a name="cd2dlayer__create">\</a>  CD2DLayer::Create  
 Creates a CD2DLayer.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 A pointer to the render target.  
  
### Return Value  
 If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.  
  
##  \<a name="cd2dlayer__destroy">\</a>  CD2DLayer::Destroy  
 Destroys a CD2DLayer object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="cd2dlayer__detach">\</a>  CD2DLayer::Detach  
 Detaches resource interface from the object  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to detached resource interface.  
  
##  \<a name="cd2dlayer__get">\</a>  CD2DLayer::Get  
 Returns ID2D1Layer interface  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to an ID2D1Layer interface or NULL if object is not initialized yet.  
  
##  \<a name="cd2dlayer__getsize">\</a>  CD2DLayer::GetSize  
 Returns the size of the render target in device-independent pixels  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 The current size of the render target in device-independent pixels  
  
##  \<a name="cd2dlayer__isvalid">\</a>  CD2DLayer::IsValid  
 Checks resource validity  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 TRUE if resource is valid; otherwise FALSE.  
  
##  \<a name="cd2dlayer__m_player">\</a>  CD2DLayer::m_pLayer  
 Stores a pointer to an ID2D1Layer object.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
##  \<a name="cd2dlayer__operator_id2d1layer_star">\</a>  CD2DLayer::operator ID2D1Layer*  
 Returns ID2D1Layer interface  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to an ID2D1Layer interface or NULL if object is not initialized yet.  
  
## See Also  
 [MFC Classes](../vs140/mfc-classes.md)