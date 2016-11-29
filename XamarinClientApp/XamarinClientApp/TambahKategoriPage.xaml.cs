﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinClientApp.Models;
using RestSharp.Portable.HttpClient;
using RestSharp.Portable;

namespace XamarinClientApp
{
    public partial class TambahKategoriPage : ContentPage
    {
        public TambahKategoriPage()
        {
            InitializeComponent();

            btnTambahKategori.Clicked += BtnTambahKategori_Clicked;
        }

        private RestClient _client =
            new RestClient("http://contohinventorydb.azurewebsites.net/");

        private async void BtnTambahKategori_Clicked(object sender, EventArgs e)
        {
            var _request = new RestRequest("api/Kategori", Method.POST);
            var newKategori = new Kategori { NamaKategori = txtNamaKategori.Text };
            _request.AddBody(newKategori);
            try
            {
                var _response = await _client.Execute(_request);
                if(_response.StatusCode==System.Net.HttpStatusCode.OK)
                {

                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", "Error : " + ex.Message , "OK");
            }
        }
    }
}
