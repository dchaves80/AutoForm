<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="View.ascx.cs" Inherits="Christoc.Modules.DNNModule6.View" %>
<style>
     .overlap_table {
	display:table;
	width:100%;

}
.overlap_tablerow {
	display:table-row;

}
.overlap_tablecelllabel {
	display:table-cell;
    background-color:#583d3d;
    color:#ebe1e1;
    font-family:CG;
}
.overlap_tablecellfield {
	display:table-cell;
    background-color:#e5e3e3;
    color:#525050;
    font-family:CG;

}
    .overlap_inputfield {
        width:100%;
        background-color:inherit;
        border:none;
        border-bottom-style:solid;
        border-bottom-color:rgba(0, 0, 0, 0.74);
        border-bottom-width:1px;
       
    }
    .overlap_button {
        background:#099b5c;
        border:none;
        padding-top:10px;
        padding-bottom:10px;
        width:100%;
        color:#efe6e6;
        font-family:CG;
        border-radius:5px;
        
    }
    .overlap_button:hover {
        color:#fff;
        background:#057846;

    }
    .msgBox {
        display:table-cell;
        font-family:CG;
        vertical-align:middle;
        text-align:center;
        background-color:#099b5c;
        color:white;
    }

</style>

<div class="overlap_table" runat="server" id="formulario">
    <div class="overlap_tablerow">
        <div class="overlap_tablecelllabel">Nombre y apellido</div>
        <div class="overlap_tablecellfield"><input type="text" id="field_nombre" runat="server" class="overlap_inputfield" /></div>
    </div>
     <div class="overlap_tablerow">
        <div class="overlap_tablecelllabel">Direccion</div>
        <div class="overlap_tablecellfield"><input type="text" id="field_direccion" runat="server" class="overlap_inputfield" /></div>
    </div>
     <div class="overlap_tablerow">
        <div class="overlap_tablecelllabel">Localidad</div>
        <div class="overlap_tablecellfield"><input type="text" id="field_localidad" runat="server" class="overlap_inputfield" /></div>
    </div>
     <div class="overlap_tablerow">
        <div class="overlap_tablecelllabel">Telefono</div>
        <div class="overlap_tablecellfield"><input type="text" id="field_telefono" runat="server" class="overlap_inputfield" /></div>
    </div>
</div>
<div><input type="button" id="fieldbutton" runat="server" class="overlap_button" value="ENVIAR CONSULTA"  /></div>
<div style="display:table;width:100%" >
<div runat="server" visible="false" id="msgBox" class="msgBox">Gracias por confiar en FIAT un representante se comunicara con usted a la brevedad</div>
</div>