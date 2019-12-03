<?xml version="1.0"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
<xsl:output method="html"/>
  <xsl:template match="bookshop">
    <h1>
      <xsl:value-of select="@Name"/>
    </h1>
    <table border="5">
      <TR>
        <xsl:for-each select="category">
          <xsl:for-each select="book">
            <TR>
              <TD>
                <table border ="0" width="1200">
                  <TR>
                    <th style="width:10%;">
                      <p align="left">Назва</p>
                    </th>
                    <th style ="width 90%;">
                      <p align="left">
                        <xsl:value-of select="@Name"/>
                      </p>
                    </th>
                  </TR>
                </table>
              </TD>
            </TR>
            <TR>
              <TD>
                <table border ="0" width="1200">
                  
                  <th style="width:10%;">
                    <p align="left">Автор</p>
                  </th>
                  <th style ="width 90%;">
                    <p align="left">
                      <xsl:value-of select="@Author"/>
                    </p>
                  </th>
               
          </table>
    </TD>
    </TR>
            <TR>
              <TD>
                <table border ="0" width="1200">

                  <th style="width:10%;">
                    <p align="left">Жанр</p>
                  </th>
                  <th style ="width 90%;">
                    <p align="left">
                      <xsl:value-of select="@Genre"/>
                    </p>
                  </th>

                </table>
              </TD>
            </TR>
            <TR>
              <TD>
                <table border ="0" width="1200">

                  <th style="width:10%;">
                    <p align="left">Рік публікації</p>
                  </th>
                  <th style ="width 90%;">
                    <p align="left">
                      <xsl:value-of select="@Year"/>
                    </p>
                  </th>

                </table>
              </TD>
            </TR>
            <TR>
              <TD>
                <table border ="0" width="1200">

                  <th style="width:10%;">
                    <p align="left">Мова</p>
                  </th>
                  <th style ="width 90%;">
                    <p align="left">
                      <xsl:value-of select="@Language"/>
                    </p>
                  </th>

                </table>
              </TD>
            </TR>
            <TR>
              <TD>
                <table border ="0" width="1200">

                  <th style="width:10%;">
                    <p align="left">Опис</p>
                  </th>
                  <th style ="width 90%;">
                    <p align="left">
                      <xsl:value-of select="@Description"/>
                    </p>
                  </th>

                </table>
              </TD>
            </TR>
    </xsl:for-each>
    </xsl:for-each>
    </TR>
    </table>
  </xsl:template>
</xsl:stylesheet>