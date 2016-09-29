---
title: "CMFCRibbonUndoButton Class"
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
  - "CMFCRibbonUndoButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCRibbonUndoButton class"
ms.assetid: 5c42adf7-871d-4239-901e-47ae7fb816fc
caps.latest.revision: 34
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonUndoButton Class
The `CMFCRibbonUndoButton` class implements a drop-down list button that contains the most recent user commands. Users can select one or more of the most recent commands from the drop-down list to either redo or undo them.  
  
## Syntax  
  
```  
class CMFCRibbonUndoButton : public CMFCRibbonGallery  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCRibbonUndoButton::CMFCRibbonUndoButton](#cmfcribbonundobutton__cmfcribbonundobutton)|Constructs a new `CMFCRibbonUndoButton` object by using the command ID that you specify, text label and images from the image list of the parent object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCRibbonUndoButton::AddUndoAction](#cmfcribbonundobutton__addundoaction)|Adds a new action to the list of actions.|  
|[CMFCRibbonUndoButton::CleanUpUndoList](#cmfcribbonundobutton__cleanupundolist)|Clears the action list, which is the drop-down list.|  
|[CMFCRibbonUndoButton::GetActionNumber](#cmfcribbonundobutton__getactionnumber)|Determines the number of items that a user selected from the drop-down list.|  
|[CMFCRibbonUndoButton::HasMenu](#cmfcribbonundobutton__hasmenu)|Indicates whether the object contains a menu.|  
  
## Remarks  
 The `CMFCRibbonUndoButton` class uses a stack to represent the drop-down list.  
  
## Example  
 The following example demonstrates how to construct an object of the `CMFCRibbonUndoButton` class, and add a new action to the list of actions. This code snippet is part of the [Ribbon Gadgets sample](../VS_csharp/visual-c---samples.md).  
  
 [!code[NVC_MFC_RibbonGadgets#2](../VS_csharp/codesnippet/CPP/cmfcribbonundobutton-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../VS_csharp/cobject-class.md)  
  
 [CMFCRibbonBaseElement](../VS_csharp/cmfcribbonbaseelement-class.md)  
  
 [CMFCRibbonButton](../VS_csharp/cmfcribbonbutton-class.md)  
  
 [CMFCRibbonGallery](../VS_csharp/cmfcribbongallery-class.md)  
  
 [CMFCRibbonUndoButton](../VS_csharp/cmfcribbonundobutton-class.md)  
  
## Requirements  
 **Header:** afxribbonundobutton.h  
  
##  <a name="cmfcribbonundobutton__addundoaction"></a>  CMFCRibbonUndoButton::AddUndoAction  
 Adds a new action to the list of actions.  
  
```  
void AddUndoAction(  
   LPCTSTR lpszLabel   
);  
```  
  
### Parameters  
 [in] `lpszLabel`  
 The action label that will be displayed in the drop-down list.  
  
##  <a name="cmfcribbonundobutton__cleanupundolist"></a>  CMFCRibbonUndoButton::CleanUpUndoList  
 Clears the action list, which is the drop-down list.  
  
```  
void CleanUpUndoList();  
```  
  
##  <a name="cmfcribbonundobutton__cmfcribbonundobutton"></a>  CMFCRibbonUndoButton::CMFCRibbonUndoButton  
 Constructs a new `CMFCRibbonUndoButton` object by using the command ID that you specify, text label and images from the image list of the parent object.  
  
```  
CMFCRibbonUndoButton(  
   UINT nID,  
   LPCTSTR lpszText,  
   int nSmallImageIndex=-1,  
   int nLargeImageIndex=-1   
);  
CMFCRibbonUndoButton(  
   UINT nID,  
   LPCTSTR lpszText,  
   HICON hIcon   
);  
```  
  
### Parameters  
 [in] `nID`  
 Specifies the command identifier.  
  
 [in] `lpszText`  
 Specifies the text label of the button.  
  
 [in] `nSmallImageIndex`  
 Zero-based index in the image list of the parent object for the button's small image.  
  
 [in] `nLargeImageIndex`  
 Zero-based index in the image list of the parent object for the of button's large image.  
  
 [in] `hIcon`  
 A handle to an icon that you can use as a button's image.  
  
##  <a name="cmfcribbonundobutton__getactionnumber"></a>  CMFCRibbonUndoButton::GetActionNumber  
 Determines the number of items that a user selected from the drop-down list.  
  
```  
int GetActionNumber() const;  
```  
  
### Return Value  
 The number of items that a user selected.  
  
##  <a name="cmfcribbonundobutton__hasmenu"></a>  CMFCRibbonUndoButton::HasMenu  
 Indicates whether the object contains a menu.  
  
```  
virtual BOOL HasMenu() const;  
```  
  
### Return Value  
 Always returns `TRUE`.  
  
### Remarks  
  
## See Also  
 [Hierarchy Chart](../VS_csharp/hierarchy-chart.md)   
 [Classes](../VS_csharp/mfc-classes.md)   
 [CMFCRibbonGallery](../VS_csharp/cmfcribbongallery-class.md)   
 [CMFCRibbonButton](../VS_csharp/cmfcribbonbutton-class.md)