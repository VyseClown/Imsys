﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ddlCategoria.DataSource = (new ImovelBusiness().listarCategorias(""));
            ddlCategoria.DataValueField = "id";
            ddlCategoria.DataBind();
            ddlCategoria.Items.Insert(0, new ListItem("Selecione uma cateogira", "0"));

            ddlValor.DataSource = (new ImovelBusiness().listarImoveisValor(0));
            ddlValor.DataValueField = "valor";
            ddlValor.DataTextField = "Preço";
            ddlValor.DataBind();
            ddlValor.Items.Insert(0, new ListItem("- Selecione um valor -", "0"));


            imoveisItens.DataSource = (new ImovelBusiness().listarImoveis(0));
            imoveisItens.DataBind();
        }
    }
}