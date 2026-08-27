using Zenject;
using Player;
using UnityEngine;

public class PlayerInstaller: MonoInstaller
{
    [SerializeField] private PlayerMovement _playerMovement;
    public override void InstallBindings()
    {
        Container.Bind<PlayerMovement>().FromInstance(_playerMovement).AsSingle().NonLazy();
    }
}
