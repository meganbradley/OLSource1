---
title: "&lt;var&gt; (JavaScript)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "<var> JavaScript XML tag"
  - "var JavaScript XML tag"
ms.assetid: 34ff9023-c81c-46d1-85b6-0022f0962e66
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;var&gt; (JavaScript)
Specifies documentation information for a variable.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Optional. The data type of the variable. The type can be one of the following:  
  
-   An ECMAScript language type that's in the ECMAScript 5 specification, such as <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
-   A DOM object, such as <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
-   A JavaScript constructor function.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Optional. If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, specifies whether the variable is an integer. Set to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to indicate that the variable is an integer; otherwise, set to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. This attribute is not used by Visual Studio to provide IntelliSense information.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Optional. This attribute is deprecated; the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> attribute takes precedence over this attribute. This attribute specifies whether the documented variable is a DOM element. Set to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to specify that the variable is a DOM element; otherwise, set to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. If the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> attribute is not set and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, IntelliSense treats the documented variable as an <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> when performing statement completion.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 Optional. Specifies whether the documented variable can be set to null. Set to <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> to indicate that the variable can be set to null; otherwise, set to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. The default value is <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. This attribute is not used by Visual Studio to provide IntelliSense information.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 Optional. If <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, this attribute specifies the type of the elements in the array.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 Optional. If <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, this attribute specifies whether the elements in the array are integers. Set to <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> to indicate that the elements in the array are integers; otherwise, set to <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>. This attribute is not used by Visual Studio to provide IntelliSense information.  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 Optional. This attribute is deprecated; the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> attribute takes precedence over this attribute. If <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, this attribute specifies whether the elements in the array are DOM elements. Set to <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> to specify that the elements are DOM elements; otherwise, set to <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>. If the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> attribute is not set and <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, IntelliSense treats each element in the array as an <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> when performing statement completion.  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 Optional. If <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, specifies whether the elements in the array can be set to null. Set to <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> to indicate that the elements in the array can be set to null; otherwise, set to <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>. The default value is <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>. This attribute is not used by Visual Studio to provide IntelliSense information.  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 Optional. The keyword for F1 Help.  
  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 Optional. The identifier for localization information about the variable. The identifier is either a member ID or it corresponds to the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> attribute value in a message bundle defined by OpenAjax metadata. The identifier type depends on the format specified in the [\<loc>](../vs140/-loc---javascript-.md) tag.  
  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 Optional. A description of the variable.  
  
## Example  
 The following code example shows how to use the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> element.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [XML Documentation Comments](../vs140/xml-documentation-comments--javascript-.md)