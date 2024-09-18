using AulaMVVMHTTPClient.Models;
using AulaMVVMHTTPClient.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AulaMVVMHTTPClient.ViewModels
{
    public partial class PostViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Post> posts;
        public PostServices PostServices;
        public ICommand getPostsCommand { get;}

        public PostViewModel(){
            getPostsCommand = new Command(getPosts);
        }
        public async void getPosts()
        {
            //Buscar os dados da API
            PostServices posts = new PostServices();
            Posts = await PostServices.GetPosts();


        }
    }
}
