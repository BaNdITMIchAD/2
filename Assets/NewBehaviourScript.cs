using Unity.VisualScripting;
using UnityEngine;
public class CharacterMovementController : MonoBehaviour
// ���������� ��� ��������� �������� �������� � �������� [SerializeField] private float MoveSpeed; // ������� �������� ������ [SerializeField] private float TurnSpeed; // �������� �������� ������� [SerializeField] private float RunSpeed; // �������� ���� float tempSpeed; // ���� �����, ����� ������� ����������� �������� ����� ����
// ����������, ����������� ��� ���������� ��������� [SerializeField] private Rigidbody characterRigidbody;
void Start()
   {
    private void Move()
// �������� ����������� �������� �� ��� Z (������/�����)
float moveDirection = Input.GetAxis("Vertical"); Vector3 movement = transform.forward * moveDirection * MoveSpeed * Time.deltaTime
// ���������� ��������� characterRigidbody. MovePosition(characterRigidbody.position + movement);
if (Input.GetKeyDown(KeyCode.LeftShift))
tempSpeed = MoveSpeed;
MoveSpeed = RunSpeed;
else if (Input.GetKeyUp(KeyCode.LeftShift))
MoveSpeed = tempSpeed;
}
private void Turn()
// �������� ����������� �������� �� ��� Y (�����/������) float turnDirection = Input.GetAxis("Horizontal"); float turn = turnDirection * TurnSpeed * Time.deltaTime;
// ������������ ��������� ������ ��� Y Vector3 rotation = new Vector3(0, turn, 0); Quaternion deltaRotation = Quaternion. Euler(rotation); characterRigidbody.MoveRotation(characterRigidbody.rotation *
deltaRotation);

