---
title: "CMFCRibbonComboBox Class"
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
  - "CMFCRibbonComboBox"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCRibbonComboBox class"
ms.assetid: 9b29a6a4-cf17-4152-9b13-0bf90784b30d
caps.latest.revision: 34
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonComboBox Class
The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> class implements a combo box control that you can add to a ribbon bar, a ribbon panel, or a ribbon popup menu.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCRibbonComboBox::CMFCRibbonComboBox](#cmfcribboncombobox__cmfcribboncombobox)|Constructs a CMFCRibbonComboBox object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[AddItem](#cmfcribboncombobox__additem)|Appends a unique item to the list box.|  
|[DeleteItem](#cmfcribboncombobox__deleteitem)|Deletes a specified item from the list box.|  
|[EnableDropDownListResize](#cmfcribboncombobox__enabledropdownlistresize)|Specifies whether the list box can change size when it drops down.|  
|[FindItem](#cmfcribboncombobox__finditem)|Returns the index of the first item in the list box that matches a specified string.|  
|[GetCount](#cmfcribboncombobox__getcount)|Returns the number of items in the list box.|  
|[GetCurSel](#cmfcribboncombobox__getcursel)|Gets the index of the currently selected item in the list box.|  
|[GetDropDownHeight](#cmfcribboncombobox__getdropdownheight)|Gets the height of the list box when the list box is dropped down.|  
|[GetIntermediateSize](#cmfcribboncombobox__getintermediatesize)|Returns the size of the combo box as displayed in intermediate mode.|  
|[GetItem](#cmfcribboncombobox__getitem)|Returns the string associated with an item at a specified index in the list box.|  
|[GetItemData](#cmfcribboncombobox__getitemdata)|Returns the data associated with an item at a specified index in the list box.|  
|[HasEditBox](#cmfcribboncombobox__haseditbox)|Indicates whether the control contains an edit box.|  
|[IsResizeDropDownList](#cmfcribboncombobox__isresizedropdownlist)|Indicates whether or not the list box can be resized.|  
|[OnSelectItem](#cmfcribboncombobox__onselectitem)|Called by the framework when the user selects an item in the list box.|  
|[RemoveAllItems](#cmfcribboncombobox__removeallitems)|Deletes all items from the list box and clears the edit box.|  
|[SelectItem](#cmfcribboncombobox__selectitem)|Selects an item in the list box.|  
|[SetDropDownHeight](#cmfcribboncombobox__setdropdownheight)|Sets the height of the list box when it is dropped down.|  
  
## Remarks  
 The ribbon combo box consists of a list box combined with either a static label or label that can be edited by the user. You must specify which type you want when you create your ribbon combo box.  
  
## Example  
 The following example demonstrates how to construct an object of the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> class, add an item to the combo box, select an item in the combo box, and add a combo box to a panel.  
  
 [!code[NVC_MFC_RibbonApp#11](../vs140/codesnippet/CPP/cmfcribboncombobox-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CMFCRibbonBaseElement](../vs140/cmfcribbonbaseelement-class.md)  
  
 [CMFCRibbonButton](../vs140/cmfcribbonbutton-class.md)  
  
 [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md)  
  
 [CMFCRibbonComboBox](../vs140/cmfcribboncombobox-class.md)  
  
## Requirements  
 **Header:** afxribboncombobox.h  
  
##  \<a name="cmfcribboncombobox__additem">\</a>  CMFCRibbonComboBox::AddItem  
 Appends a unique item to the list box.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The string of the item to add.  
  
 [in] <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 The data associated with the item to add.  
  
### Return Value  
 The zero-based index of the appended item.  
  
##  \<a name="cmfcribboncombobox__cmfcribboncombobox">\</a>  CMFCRibbonComboBox::CMFCRibbonComboBox  
 Constructs a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 The ID of the combo box.  
  
 [in] <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> if you want an edit box within the control; <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> otherwise.  
  
 [in] <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 Width of the combo box in pixels; or -1 for the default width.  
  
 [in] <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 The display label of the combo box.  
  
 [in] <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 The small image index of the combo box.  
  
### Remarks  
 The default width is 108 pixels.  
  
##  \<a name="cmfcribboncombobox__deleteitem">\</a>  CMFCRibbonComboBox::DeleteItem  
 Deletes a specified item from the list box.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 The zero-based index of the item to be deleted.  
  
 [in] <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 The data associated with the item to be deleted.  
  
 [in] <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 The string of the item to be deleted. If there are multiple items with the same string, the first item is deleted.  
  
### Return Value  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> if the specified item has been deleted; otherwise, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribboncombobox__enabledropdownlistresize">\</a>  CMFCRibbonComboBox::EnableDropDownListResize  
 Specifies whether the list box can change size when it drops down.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> to enable resizing; <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> to disable resizing.  
  
### Remarks  
 When resizing is enabled, the list box will change size to fit the items it displays.  
  
##  \<a name="cmfcribboncombobox__finditem">\</a>  CMFCRibbonComboBox::FindItem  
 Returns the index of the first item in the list box that matches a specified string.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 The string of an item in the list box.  
  
### Return Value  
 The zero-based index of the item; or -1 if the item is not found.  
  
### Remarks  
  
##  \<a name="cmfcribboncombobox__getcount">\</a>  CMFCRibbonComboBox::GetCount  
 Returns the number of items in the list box.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 The number of items in the list box, or 0 if the list box contains no items.  
  
### Remarks  
  
##  \<a name="cmfcribboncombobox__getcursel">\</a>  CMFCRibbonComboBox::GetCurSel  
 Gets the index of the currently selected item in the list box.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 The zero-based index of the currently selected item in the list box; or -1 if no item is selected.  
  
##  \<a name="cmfcribboncombobox__getdropdownheight">\</a>  CMFCRibbonComboBox::GetDropDownHeight  
 Gets the height of the list box when the list box is dropped down.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 The height, in pixels, of the list box.  
  
### Remarks  
  
##  \<a name="cmfcribboncombobox__getintermediatesize">\</a>  CMFCRibbonComboBox::GetIntermediateSize  
 Returns the size of the combo box as displayed in intermediate mode.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 Pointer to a device context for the combo box.  
  
### Return Value  
 The size of the combo box.  
  
### Remarks  
 The size returned is based on the size of the combo box when it displays small images.  
  
##  \<a name="cmfcribboncombobox__getitem">\</a>  CMFCRibbonComboBox::GetItem  
 Returns the string associated with an item at a specified index in the list box.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 The zero-based index of an item in the list box.  
  
### Return Value  
 A pointer to the string that is associated with the item; otherwise, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> if the index parameter is invalid, or if the index parameter is -1 and there is no item selected in the combo box.  
  
### Remarks  
  
##  \<a name="cmfcribboncombobox__getitemdata">\</a>  CMFCRibbonComboBox::GetItemData  
 Returns the data associated with an item at a specified index in the list box.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 The zero-based index of an item in the list box.  
  
### Return Value  
 The data associated with the item; or 0 if the item does not exist, or if the index parameter is -1 and there is no selected item in the list box.  
  
##  \<a name="cmfcribboncombobox__haseditbox">\</a>  CMFCRibbonComboBox::HasEditBox  
 Indicates whether the control contains an edit box.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> if the control contains an edit box; otherwise, <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribboncombobox__isresizedropdownlist">\</a>  CMFCRibbonComboBox::IsResizeDropDownList  
 Indicates whether or not the list box can be resized.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> if the list box can be resized; otherwise <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>. [](#cmfcribboncombobox__enabledropdownlistresize)  
  
### Remarks  
 You can enable list box resizing by using the [EnableDropDownListResize](#cmfcribboncombobox__enabledropdownlistresize) method.  
  
##  \<a name="cmfcribboncombobox__onselectitem">\</a>  CMFCRibbonComboBox::OnSelectItem  
 Called by the framework when a user selects an item in the list box.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 The index of the selected item.  
  
### Remarks  
 Override this method if you want to process a user input selection.  
  
##  \<a name="cmfcribboncombobox__removeallitems">\</a>  CMFCRibbonComboBox::RemoveAllItems  
 Deletes all items from the list box and clears the edit box.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcribboncombobox__selectitem">\</a>  CMFCRibbonComboBox::SelectItem  
 Selects an item in the list box.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 The zero-based index of an item in the list box.  
  
 [in] <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 The data associated with an item in the list box.  
  
 [in] <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 The string of an item in the list box.  
  
### Return Value  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> if the method was successful; otherwise <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribboncombobox__setdropdownheight">\</a>  CMFCRibbonComboBox::SetDropDownHeight  
 Sets the height of the list box when it is dropped down.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 The height, in pixels, of the list box.  
  
### Remarks  
 The default height is 150 pixels.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md)