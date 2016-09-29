---
title: "CD2DPathGeometry Class"
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
  - "afxrendertarget/CD2DPathGeometry"
  - "CD2DPathGeometry"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CD2DPathGeometry class"
ms.assetid: 686216eb-5080-4242-ace5-8fa1ce96307c
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DPathGeometry Class
A wrapper for ID2D1PathGeometry.  
  
## Syntax  
  
```  
class CD2DPathGeometry : public CD2DGeometry;  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DPathGeometry::CD2DPathGeometry](#cd2dpathgeometry__cd2dpathgeometry)|Constructs a CD2DPathGeometry object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DPathGeometry::Attach](#cd2dpathgeometry__attach)|Attaches existing resource interface to the object|  
|[CD2DPathGeometry::Create](#cd2dpathgeometry__create)|Creates a CD2DPathGeometry. (Overrides [CD2DResource::Create](../VS_csharp/cd2dresource-class.md#cd2dresource__create).)|  
|[CD2DPathGeometry::Destroy](#cd2dpathgeometry__destroy)|Destroys a CD2DPathGeometry object. (Overrides [CD2DGeometry::Destroy](../VS_csharp/cd2dgeometry-class.md#cd2dgeometry__destroy).)|  
|[CD2DPathGeometry::Detach](#cd2dpathgeometry__detach)|Detaches resource interface from the object|  
|[CD2DPathGeometry::GetFigureCount](#cd2dpathgeometry__getfigurecount)|Retrieves tthe number of figures in the path geometry.|  
|[CD2DPathGeometry::GetSegmentCount](#cd2dpathgeometry__getsegmentcount)|Retrieves the number of segments in the path geometry.|  
|[CD2DPathGeometry::Open](#cd2dpathgeometry__open)|Retrieves the geometry sink that is used to populate the path geometry with figures and segments.|  
|[CD2DPathGeometry::Stream](#cd2dpathgeometry__stream)|Copies the contents of the path geometry to the specified ID2D1GeometrySink.|  
  
### Protected Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DPathGeometry::m_pPathGeometry](#cd2dpathgeometry__m_ppathgeometry)|A pointer to an ID2D1PathGeometry.|  
  
## Inheritance Hierarchy  
 [CObject](../VS_csharp/cobject-class.md)  
  
 [CD2DResource](../VS_csharp/cd2dresource-class.md)  
  
 [CD2DGeometry](../VS_csharp/cd2dgeometry-class.md)  
  
 [CD2DPathGeometry](../VS_csharp/cd2dpathgeometry-class.md)  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
##  <a name="cd2dpathgeometry__attach"></a>  CD2DPathGeometry::Attach  
 Attaches existing resource interface to the object  
  
```  
void Attach(  
   ID2D1PathGeometry* pResource  
);  
```  
  
### Parameters  
 `pResource`  
 Existing resource interface. Cannot be NULL  
  
##  <a name="cd2dpathgeometry__cd2dpathgeometry"></a>  CD2DPathGeometry::CD2DPathGeometry  
 Constructs a CD2DPathGeometry object.  
  
```  
CD2DPathGeometry(  
   CRenderTarget* pParentTarget,  
   BOOL bAutoDestroy = TRUE  
);  
```  
  
### Parameters  
 `pParentTarget`  
 A pointer to the render target.  
  
 `bAutoDestroy`  
 Indicates that the object will be destroyed by owner (pParentTarget).  
  
##  <a name="cd2dpathgeometry__create"></a>  CD2DPathGeometry::Create  
 Creates a CD2DPathGeometry.  
  
```  
virtual HRESULT Create(  
   CRenderTarget* pRenderTarget  
);  
```  
  
### Parameters  
 `pRenderTarget`  
 A pointer to the render target.  
  
### Return Value  
 If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.  
  
##  <a name="cd2dpathgeometry__destroy"></a>  CD2DPathGeometry::Destroy  
 Destroys a CD2DPathGeometry object.  
  
```  
virtual void Destroy();  
```  
  
##  <a name="cd2dpathgeometry__detach"></a>  CD2DPathGeometry::Detach  
 Detaches resource interface from the object  
  
```  
ID2D1PathGeometry* Detach();  
```  
  
### Return Value  
 Pointer to detached resource interface.  
  
##  <a name="cd2dpathgeometry__getfigurecount"></a>  CD2DPathGeometry::GetFigureCount  
 Retrieves tthe number of figures in the path geometry.  
  
```  
int GetFigureCount() const;  
```  
  
### Return Value  
 Returns the number of figures in the path geometry.  
  
##  <a name="cd2dpathgeometry__getsegmentcount"></a>  CD2DPathGeometry::GetSegmentCount  
 Retrieves the number of segments in the path geometry.  
  
```  
int GetSegmentCount() const;  
```  
  
### Return Value  
 Returns the number of segments in the path geometry.  
  
##  <a name="cd2dpathgeometry__m_ppathgeometry"></a>  CD2DPathGeometry::m_pPathGeometry  
 A pointer to an ID2D1PathGeometry.  
  
```  
ID2D1PathGeometry* m_pPathGeometry;  
```  
  
##  <a name="cd2dpathgeometry__open"></a>  CD2DPathGeometry::Open  
 Retrieves the geometry sink that is used to populate the path geometry with figures and segments.  
  
```  
ID2D1GeometrySink* Open();  
```  
  
### Return Value  
 A pointer to the ID2D1GeometrySink that is used to populate the path geometry with figures and segments.  
  
##  <a name="cd2dpathgeometry__stream"></a>  CD2DPathGeometry::Stream  
 Copies the contents of the path geometry to the specified ID2D1GeometrySink.  
  
```  
BOOL Stream(  
   ID2D1GeometrySink* geometrySink  
);  
```  
  
### Parameters  
 `geometrySink`  
 The sink to which the path geometry's contents are copied. Modifying this sink does not change the contents of this path geometry.  
  
### Return Value  
 If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.  
  
## See Also  
 [MFC Classes](../VS_csharp/mfc-classes.md)