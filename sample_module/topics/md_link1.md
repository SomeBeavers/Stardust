[//]: # (title: md_link1.md)

# Link1

<p id="Link2">
</p>

<chapter title="Link3" id="Link3.WithDot">
My
<code id="Link5" lang="c#" style="block">
private void Test(){}
</code>
</chapter>

Anchor: <anchor name="Link4"/>

<tabs>
<tab title="Use xml links">
            <p>
                <a href="xml_link1.xml" anchor="navigate-to-md">Use id as link</a>
            </p>
            <p>
                <a href="xml_link1.xml" anchor="Link1.WithDot">Use id with dot as link</a>
            </p>
            <p>
                <a href="xml_link1.xml" anchor="InnerLink">Use id of inner element as link</a>
            </p>
            <p>
                <a href="xml_link1.xml" anchor="AnchorLink">Use anchor as link</a>
            </p>
</tab>
</tabs>

# Use xml links (md style)

[Use id as link](xml_link1.xml#navigate-to-md)
[Use id with dot as link](xml_link1.xml#Link1.WithDot)
[Use id of inner element as link](xml_link1.xml#InnerLink)
[Use anchor as link](xml_link1.xml#AnchorLink)

# Use md links in same file (md style)
[](#Link2)
[](#Link3.WithDot)
[](#Link4)
[](#Link5)



