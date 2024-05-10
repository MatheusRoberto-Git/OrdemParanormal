using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OP_RPG.Models.Account;

namespace OP_RPG.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                if (string.IsNullOrEmpty(model.Username) && string.IsNullOrEmpty(model.Password))
                {
                    ModelState.Remove("UserName");
                    ModelState.Remove("Password");
                    ModelState.AddModelError("Mensagem", "Aaaaaaaiiinnnnn como eu tô pliguicinhaaa hojeeeee, numm queeroo escrever naaaddaaaaaa... Arrombado de merda, na moral como tu é petista véi!");
                }

                return View(model);
            }

            var user = await _userManager.FindByNameAsync(model.Username);

            if (user != null)
            {
                var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            ModelState.AddModelError("Mensagem", "Que burro da 0 pra ele... kkk Muito burro, deve ser terraplanista!");
            return View(model);

        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                if (string.IsNullOrEmpty(model.Username) && string.IsNullOrEmpty(model.Email) && string.IsNullOrEmpty(model.Password) && string.IsNullOrEmpty(model.ConfirmarSenha))
                {
                    ModelState.Remove("Username");
                    ModelState.Remove("Email");
                    ModelState.Remove("Password");
                    ModelState.Remove("ConfirmarSenha");
                    ModelState.AddModelError("Mensagem", "Seu desgraçado, arrombado de merda... Nem cria seu perfil na moral, se vc não quer escrever nada vai procurar teu pai que foi comprar cigarro e nunca mais voltou!");
                }                

                return View(model);
            }
            else if (ModelState.IsValid)
            {
                var user = new IdentityUser 
                { 
                    UserName = model.Username,
                    Email = model.Email
                };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    this.ModelState.AddModelError("Mensagem", "Tenta de novo...");
                }
            }

            return View(model);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            HttpContext.Session.Clear();
            HttpContext.User = null;
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }
    }
}
