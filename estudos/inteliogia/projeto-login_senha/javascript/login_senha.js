const usuarios = [
    {
        login: 'flavio',
        senha: 'flavio'
    },

    {
        login: 'lucia',
        senha: 'lucia'
    },

    {
        login: 'admin',
        senha: 'admin'
    }

]

let botao = document.getElementById('btnLogar');

botao.addEventListener('click', function logar() {
    let EnterUsuario = document.getElementById('usuario').value;
    let EnterSenha = document.getElementById('senha').value;
    let validaLogin = false

    for(let i in usuarios) {

        if (EnterUsuario == usuarios[i].login && EnterSenha == usuarios[i].senha){
            validaLogin = true
            break
        }
    }

    if (validaLogin == true) {
        location.href = "homepage.html"
    } else {
        alert('Usuário e senha incorretos!!!!')
    }
})


