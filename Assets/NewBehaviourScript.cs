using Unity.VisualScripting;
using UnityEngine;
public class CharacterMovementController : MonoBehaviour
// Переменные для настройки скорости движения и поворота [SerializeField] private float MoveSpeed; // Обычная скорость ходьбы [SerializeField] private float TurnSpeed; // Скорость вращения объекта [SerializeField] private float RunSpeed; // Скорость бега float tempSpeed; // Поле нужно, чтобы хранить изначальную скорость после бега
// Компоненты, необходимые для управления движением [SerializeField] private Rigidbody characterRigidbody;
void Start()
   {
    private void Move()
// Получаем направление движения по оси Z (вперед/назад)
float moveDirection = Input.GetAxis("Vertical"); Vector3 movement = transform.forward * moveDirection * MoveSpeed * Time.deltaTime
// Перемещаем персонажа characterRigidbody. MovePosition(characterRigidbody.position + movement);
if (Input.GetKeyDown(KeyCode.LeftShift))
tempSpeed = MoveSpeed;
MoveSpeed = RunSpeed;
else if (Input.GetKeyUp(KeyCode.LeftShift))
MoveSpeed = tempSpeed;
}
private void Turn()
// Получаем направление поворота по оси Y (влево/вправо) float turnDirection = Input.GetAxis("Horizontal"); float turn = turnDirection * TurnSpeed * Time.deltaTime;
// Поворачиваем персонажа вокруг оси Y Vector3 rotation = new Vector3(0, turn, 0); Quaternion deltaRotation = Quaternion. Euler(rotation); characterRigidbody.MoveRotation(characterRigidbody.rotation *
deltaRotation);

