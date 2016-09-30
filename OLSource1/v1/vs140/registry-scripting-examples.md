---
title: "Registry Scripting Examples"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "scripting, examples"
  - "registrar scripts [ATL]"
  - "scripts, Registrar scripts"
  - "registry, Registrar"
ms.assetid: b6df80e1-e08b-40ee-9243-9b381b172460
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Registry Scripting Examples
The scripting examples in this topic demonstrate how to add a key to the system registry, register the Registrar COM server, and specify multiple parse trees.  
  
## Add a Key to HKEY_CURRENT_USER  
 The following parse tree illustrates a simple script that adds a single key to the system registry. In particular, the script adds the key, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. It also assigns the default string value of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to the new key:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This script can easily be extended to define multiple subkeys as follows:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Now, the script adds a subkey, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. To this subkey, it adds both the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> subkey (with a default <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> value of 55) and the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> named value (with a string value of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>).  
  
##  \<a name="_atl_register_the_registrar_com_server">\</a> Register the Registrar COM Server  
 The following script registers the Registrar COM server itself.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 At run time, this parse tree adds the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> key to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. To this new key, it then:  
  
-   Specifies <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> as the key's default string value.  
  
-   Adds <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> as a subkey.  
  
-   Specifies <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. (This value is the Registrar's CLSID for use with <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.)  
  
 Since <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is shared, it should not be removed in Unregister mode. The statement, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, does this by indicating that <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> should be opened in Register mode and ignored in Unregister mode.  
  
 The <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> statement provides a housekeeping function by removing a key and all of its subkeys before re-creating the key. This can be useful if the names of the subkeys have changed. In this scripting example, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> checks to see if <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> already exists. If it does, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>:  
  
-   Recursively deletes <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> and all of its subkeys.  
  
-   Re-creates <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
-   Adds <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> as the default string value for <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
 The parse tree now adds two new subkeys to <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>. The first key, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, gets a default string value that is the ProgID. The second key, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, gets a default string value, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, that is a preprocessor value explained in the section, [Using Replaceable Parameters (The Registrar's Preprocessor)](../vs140/using-replaceable-parameters--the-registrar-s-preprocessor-.md), of this article. <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> also gets a named value, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, with a string value of <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.  
  
## Specify Multiple Parse Trees  
 To specify more than one parse tree in a script, simply place one tree at the end of another. For example, the following script adds the key, <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, to the parse trees for both <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
> [!NOTE]
>  In a Registrar script, 4K is the maximum token size. (A token is any recognizable element in the syntax.) In the previous scripting example, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> are all tokens.  
  
## See Also  
 [Creating Registrar Scripts](../vs140/creating-registrar-scripts.md)