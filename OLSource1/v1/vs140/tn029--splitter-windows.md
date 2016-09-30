---
title: "TN029: Splitter Windows"
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
  - "vc.windows.splitter"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "TN029"
  - "splitter windows, about splitter windows"
ms.assetid: 2c57ce99-2a3c-4eff-9cea-baccb13af075
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# TN029: Splitter Windows
This note describes the MFC [CSplitterWnd Class](../vs140/csplitterwnd-class.md), which provides window splits and manages the resizing of other pane windows.  
  
## Splitter Styles  
 A <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> supports two different styles of splitting windows.  
  
 In "static splitters," the splitter window creates the panes when it is created. The order and number of panes never change. Splitter bars are used to resize the different panes. You can use this style to display a different view class in each pane. The Visual C++ graphics editor and the Windows File Manager are examples of programs that use this splitter style. This style of splitter window does not use splitter boxes.  
  
 In "dynamic splitters," additional panes are created and destroyed as the user splits and un-splits new views. This splitter starts out with a single view and provides splitter boxes for the user to initiate splitting. The splitter window dynamically creates a new view object when the view is split in one direction. This new view object represents the new pane. If the view is split in two directions by using the keyboard interface, the splitter window creates three new view objects for the three new panes. While the split is active, Windows displays the splitter box as a splitter bar between the panes. Windows destroys additional view objects when the user removes a split, but the original view remains until the splitter window itself is destroyed. Microsoft Excel and Microsoft Word are examples of applications that use the dynamic splitter style.  
  
 When you create either kind of splitter window, you must specify the maximum number of rows and columns that the splitter will manage. A static splitter will create panes to fill all the rows and columns. A dynamic splitter will create only the first pane when the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is created.  
  
 The maximum number of panes you can specify for static splitters is 16 rows by 16 columns. The recommended configurations are:  
  
-   1 row x 2 columns : usually with dissimilar panes  
  
-   2 rows x 1 column : usually with dissimilar panes  
  
-   2 rows x 2 columns : usually with similar panes  
  
 The maximum number of panes that you can specify for dynamic splitters is 2 rows by 2 columns. The recommended configurations are:  
  
-   1 row x 2 columns : for columnar data  
  
-   2 rows x 1 column : for textual or other data  
  
-   2 rows x 2 columns : for grid or table oriented data  
  
## Splitter Examples  
 Many of the MFC sample programs use splitter windows directly or indirectly. The MFC General sample [VIEWEX](../vs140/visual-c---samples.md) illustrates several uses of static splitters, including how to place a splitter in a splitter.  
  
 You can also use ClassWizard to create a new multiple document interface (MDI) Child frame window class that contains a splitter window. For more information on splitter windows, see [Multiple Document Types, Views, and Frame Windows](../vs140/multiple-document-types--views--and-frame-windows.md).  
  
## Terminology Used by Implementation  
 Here is a list of terms that are specific to splitter windows:  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>:  
 A window that provides pane-splitting controls and scroll bars that are shared between all panes on a row or column. You specify rows and columns with zero-based numbers (the first pane is row = 0 and column = 0).  
  
 Pane:  
 An application-specific window that a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> manages. A pane is usually an object that is derived from the [CView Class](../vs140/cview-class.md), but can be any [CWnd](../vs140/cwnd-class.md) object that has the appropriate child window ID.  
  
 To use a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>-derived object, pass the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> of the object to the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> function as you would if you were using a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>-derived class. Your class must use <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> because the framework uses dynamic creation at runtime. Although there is a lot of code in <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> that is specific to the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> class, [CObject::IsKindOf](../vs140/cobject--iskindof.md) is always used before those actions are performed.  
  
 Splitter Bar:  
 A control that is placed between rows and columns of panes. It may be used to adjust the sizes of rows or columns of panes.  
  
 Splitter Box:  
 A control in a dynamic <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> that you can use to create new rows or columns of panes. It is located at the top of the vertical scroll bars or to the left of the horizontal scroll bars.  
  
 Splitter Intersection:  
 The intersection of a vertical splitter bar and a horizontal splitter bar. You can drag it to adjust the size of a row and column of panes simultaneously.  
  
## Shared Scroll Bars  
 The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> class also supports shared scroll bars. These scroll bar controls are children of the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and are shared with the different panes in the splitter.  
  
 For example, in a 1 row x 2 column window, you can specify WS_VSCROLL when creating the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. Windows creates a special scroll bar control that is shared between the two panes.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 When the user moves the scroll bar, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> messages will be sent to both views. When either view sets the scroll bar position, the shared scroll bar will be set.  
  
 Note that shared scroll bars are most useful with similar view objects. If you mix views of different types in a splitter, then you may have to write special code to coordinate their scroll positions. Any <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>-derived class that uses the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> scroll bar APIs will delegate to the shared scroll bar if it exists. The <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> implementation is one example of a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> class that supports shared scroll bars. Classes that are not derived from <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, classes that rely on non-control scroll bars, or classes that use standard Windows implementations (for example, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>) will not work with the shared scroll bar feature of <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
## Minimum Sizes  
 For each row there is a minimum row height, and for each column there is a minimum column width. This minimum guarantees that a pane is not too small to be shown in complete detail.  
  
 For a static splitter window, the initial minimum row height and column width is 0. For a dynamic splitter window, the initial minimum row height and column width are set by the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> parameter of the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> function.  
  
 You can change these minimum sizes by using the [CSplitterWnd::SetRowInfo](../vs140/csplitterwnd--setrowinfo.md) and [CSplitterWnd::SetColumnInfo](../vs140/csplitterwnd--setcolumninfo.md) functions.  
  
## Actual vs. Ideal Sizes  
 The layout of the panes in the splitter window depends on the size of the frame that contains them. When a user resizes the containing frame, the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> repositions and resizes the panes so that they fit as well as possible.  
  
 The user can manually set the row height and column width sizes, or the program can set the ideal size by using the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> class. The actual size can be smaller or larger than the ideal. Windows will adjust the actual size if there is not enough room to display the ideal size or if there is too much empty space on the right or bottom of the splitter window.  
  
## Custom Controls  
 You can override many functions to provide customized behavior and a customized interface. You can override this first set to provide alternate imagery for the various graphical components of a splitter window.  
  
-   <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  
 You call this function to create a shared scroll bar control. You can override it to create extra controls next to the scroll bar.  
  
-   <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
  
 These functions implement the logic of the dynamic splitter window. You can override these to provide more advanced splitter logic.  
  
-   <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
  
## CView Functionality  
 The <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> class uses the following high level commands to delegate to the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> implementation. Because these commands are virtual, the standard <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> implementation will not require the entire <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> implementation to be linked in. For applications that use <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> but not <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> implementation will not be linked with the application.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 Checks whether ID_NEXT_PANE or ID_PREV_PANE is currently possible.  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 Executes the "Next Pane" or "Previous Pane" command.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 Executes the keyboard split command, usually "Window Split".  
  
## See Also  
 [Technical Notes by Number](../vs140/technical-notes-by-number.md)   
 [Technical Notes by Category](../vs140/technical-notes-by-category.md)